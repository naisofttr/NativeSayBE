
namespace Domain.Entities;

public class Customer : EntityDateBase
{

    public string IdToken { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string ProfilePhotoUrl { get; set; }
}
