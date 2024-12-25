namespace Application.Services.AuthService;
public interface IGoogleOAuthService
{
    Task<(string AccessToken, string RefreshToken)> GetTokensAsync(string authorizationCode);
    Task<string> RefreshAccessTokenAsync(string refreshToken);
}
