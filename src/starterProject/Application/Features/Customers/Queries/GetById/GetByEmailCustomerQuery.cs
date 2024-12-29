using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Customers.Queries.GetById;
public class GetByEmailCustomerQuery : IRequest<GetByEmailCustomerResponse>
{
    public string Email { get; set; }

    public class GetByEmailCustomerQueryHandler : IRequestHandler<GetByEmailCustomerQuery, GetByEmailCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetByEmailCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<GetByEmailCustomerResponse> Handle(GetByEmailCustomerQuery request, CancellationToken cancellationToken)
        {
            Customer? customer = await _customerRepository.GetAsync(
                predicate: b => b.Email.Equals(request.Email),
                enableTracking: false,
                cancellationToken: cancellationToken
            );

            GetByEmailCustomerResponse response = _mapper.Map<GetByEmailCustomerResponse>(customer);
            return response;
        }
    }
}