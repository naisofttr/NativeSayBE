namespace Application.Dtos;
public class VerifyGoogleTokenResponse
{
    public bool Success { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Picture { get; set; }
    public string UserId { get; set; }
    public string ErrorMessage { get; set; }
}
