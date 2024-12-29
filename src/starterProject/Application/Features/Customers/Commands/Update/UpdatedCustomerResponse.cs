using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Commands.Update;
public class UpdatedCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public bool Deleted { get; set; }

    public UpdatedCustomerResponse()
    {
        Email = string.Empty;
        Name = string.Empty;
        ProfilePhotoUrl = string.Empty;
        Deleted = false;
    }

    public UpdatedCustomerResponse(Guid id, string email, string name, string profilePhotoUrl, bool deleted)
    {
        Id = id;
        Email = email;
        Name = name;
        ProfilePhotoUrl = profilePhotoUrl;
        Deleted = deleted;
    }
}
