using Application.Features.Auth.Commands.VerifyGoogleToken;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
namespace Application.Features.Customers.Commands;
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
            CreatedCustomerResponse response = new CreatedCustomerResponse();
            VerifyGoogleTokenCommand verifyGoogleToken = new VerifyGoogleTokenCommand();

            verifyGoogleToken.IdToken = request.IdToken;
            var verifyGoogleTokenResponse = _mediator.Send(verifyGoogleToken);
            if (verifyGoogleTokenResponse.Result.Success)
            {
                TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
                Customer customer = _mapper.Map<Customer>(request);

                customer.IdToken = request.IdToken;
                customer.Email = request.Email;
                customer.Name = request.Name;
                customer.ProfilePhotoUrl = request.ProfilePhotoUrl;
                customer.CreatedDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, localTimeZone);

                Customer createdCustomer = await _customerRepository.AddAsync(customer);

                response = _mapper.Map<CreatedCustomerResponse>(createdCustomer);
            }
            else
            {
                response.ErrorMessage = verifyGoogleTokenResponse.Result.ErrorMessage;
            }
            return response;
        }
    }
}
