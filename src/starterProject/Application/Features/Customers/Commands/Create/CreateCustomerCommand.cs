using Application.Dtos;
using Application.Features.Auth.Commands.VerifyGoogleToken;
using Application.Features.Customers.Commands.Create;
using Application.Features.Customers.Queries.GetById;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

public class CreateCustomerCommand : IRequest<CreatedCustomerResponse>
{
    public string IdToken { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string ProfilePhotoUrl { get; set; }

    public CreateCustomerCommand()
    {
        IdToken = string.Empty;
        Email = string.Empty;
        Name = string.Empty;
        ProfilePhotoUrl = string.Empty;
    }

    public CreateCustomerCommand(string idToken, string email, string name, string profilePhotoUrl)
    {
        IdToken = idToken;
        Email = email;
        Name = name;
        ProfilePhotoUrl = profilePhotoUrl;
    }

    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreatedCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper, IMediator mediator)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<CreatedCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = new CreatedCustomerResponse();

            var verifyGoogleTokenResponse = await VerifyGoogleTokenAsync(request.IdToken);
            if (!verifyGoogleTokenResponse.Success)
            {
                response.ErrorMessage = verifyGoogleTokenResponse.ErrorMessage;
                return response;
            }

            var existingCustomer = await GetCustomerByEmailAsync(request.Email);
            var currentDateTime = GetLocalCurrentDateTime();

            if (existingCustomer != null)
            {
                // Update customer if necessary
                if (existingCustomer.Name != request.Name || existingCustomer.ProfilePhotoUrl != request.ProfilePhotoUrl)
                {
                    existingCustomer.Name = request.Name;
                    existingCustomer.ProfilePhotoUrl = request.ProfilePhotoUrl;
                    existingCustomer.UpdatedDate = currentDateTime;

                    var updatedCustomer = await _customerRepository.UpdateAsync(existingCustomer);
                    response = _mapper.Map<CreatedCustomerResponse>(updatedCustomer);
                }
                else
                {
                    response = _mapper.Map<CreatedCustomerResponse>(existingCustomer);
                }
            }
            else
            {
                // Create new customer
                var newCustomer = _mapper.Map<Customer>(request);
                newCustomer.CreatedDate = currentDateTime;

                var createdCustomer = await _customerRepository.AddAsync(newCustomer);
                response = _mapper.Map<CreatedCustomerResponse>(createdCustomer);
            }

            return response;
        }

        private async Task<VerifyGoogleTokenResponse> VerifyGoogleTokenAsync(string idToken)
        {
            var verifyGoogleTokenCommand = new VerifyGoogleTokenCommand { IdToken = idToken };
            return await _mediator.Send(verifyGoogleTokenCommand);
        }

        private async Task<Customer?> GetCustomerByEmailAsync(string email)
        {
            var getByEmailCustomerQuery = new GetByEmailCustomerQuery { Email = email };
            var customerResponse = await _mediator.Send(getByEmailCustomerQuery);

            return _mapper.Map<Customer?>(customerResponse);
        }

        private DateTime GetLocalCurrentDateTime()
        {
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.Local);
        }
    }
}
