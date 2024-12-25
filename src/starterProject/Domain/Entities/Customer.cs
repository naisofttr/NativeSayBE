
namespace Domain.Entities;

public class Customer : EntityRecIdBase
{

    public string IdToken { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string ProfilePhotoUrl { get; set; }
}
