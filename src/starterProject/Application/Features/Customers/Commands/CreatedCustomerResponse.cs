using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Commands;
public class CreatedCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string IdToken { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string ProfilePhotoUrl { get; set; }

    public CreatedCustomerResponse()
    {
        IdToken = string.Empty;
        Email = string.Empty;
        Name = string.Empty;
        ProfilePhotoUrl = string.Empty;
    }

    public CreatedCustomerResponse(Guid id, string idToken, string email, string name, string profilePhotoUrl)
    {
        Id = id;
        IdToken = idToken;
        Email = email;
        Name = name;
        ProfilePhotoUrl = profilePhotoUrl;
    }
}
