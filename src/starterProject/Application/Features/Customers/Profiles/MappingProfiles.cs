using Application.Features.Customers.Commands.Create;
using Application.Features.Customers.Commands.Update;
using Application.Features.Customers.Queries.GetById;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Customers.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
        CreateMap<Customer, CreatedCustomerResponse>().ReverseMap();
        CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        CreateMap<Customer, UpdatedCustomerResponse>().ReverseMap();
        CreateMap<Customer, GetByEmailCustomerResponse>().ReverseMap();
        CreateMap<Customer, GetByEmailCustomerQuery>().ReverseMap();
    }
}
