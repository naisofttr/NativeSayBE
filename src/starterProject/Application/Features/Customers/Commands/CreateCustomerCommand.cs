using Application.Features.Users.Constants;
using Application.Features.Users.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
namespace Application.Features.Customers.Commands;
public class CreateCustomerCommand : IRequest<CreatedCustomerResponse>/*, ISecuredRequest*/
{
    public string IdToken { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string ProfilePhotoUrl { get; set; }

    //public string[] Roles => new[] { Admin, Write, UsersOperationClaims.Create };
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
        //private readonly UserBusinessRules _userBusinessRules;
        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper/*, UserBusinessRules userBusinessRules*/)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            //_userBusinessRules = userBusinessRules;
        }

        public async Task<CreatedCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            //await _userBusinessRules.UserEmailShouldNotExistsWhenInsert(request.Email);
            Customer customer = _mapper.Map<Customer>(request);

            //HashingHelper.CreatePasswordHash(
            //    request.Password,
            //    passwordHash: out byte[] passwordHash,
            //    passwordSalt: out byte[] passwordSalt
            //);
            customer.IdToken = request.IdToken;
            customer.Email = request.Email;
            customer.Name = request.Name;
            customer.ProfilePhotoUrl = request.ProfilePhotoUrl;
            Customer createdCustomer = await _customerRepository.AddAsync(customer);

            CreatedCustomerResponse response = _mapper.Map<CreatedCustomerResponse>(createdCustomer);
            return response;
        }
    }
}
