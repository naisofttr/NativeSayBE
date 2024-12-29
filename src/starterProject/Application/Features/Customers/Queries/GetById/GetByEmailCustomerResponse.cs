using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Queries.GetById;
public class GetByEmailCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string IdToken { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public DateTime UpdatedDate { get; set; }

    public GetByEmailCustomerResponse()
    {
        Email = string.Empty;
        Name = string.Empty;
        IdToken = string.Empty;
        ProfilePhotoUrl = string.Empty;
        UpdatedDate = DateTime.UtcNow;
    }

    public GetByEmailCustomerResponse(Guid id, string email, string name, string idToken, string profilePhotoUrl, DateTime updatedDate)
    {
        Id = id;
        Email = email;
        Name = name;
        IdToken = idToken;
        ProfilePhotoUrl = profilePhotoUrl;
        UpdatedDate = updatedDate;
    }
}
