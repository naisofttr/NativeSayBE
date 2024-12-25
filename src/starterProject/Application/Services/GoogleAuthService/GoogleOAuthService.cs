using Application.Services.AuthService;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace Application.Services.GoogleAuthService;
public class GoogleOAuthService : IGoogleOAuthService
{
    private readonly string _redirectUri = "https://www.youtube.com/";
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public GoogleOAuthService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<(string AccessToken, string RefreshToken)> GetTokensAsync(string authorizationCode)
    {
        string tokenUrl = "https://oauth2.googleapis.com/token";
        var parameters = new Dictionary<string, string>
            {
                { "client_id", _configuration["Authentication:Google:ClientId"]},
                { "client_secret", _configuration["Authentication:Google:ClientSecret"] },
                { "code", authorizationCode },
                { "grant_type", "authorization_code" },
                { "redirect_uri", _redirectUri }
            };

        var content = new FormUrlEncodedContent(parameters);
        var response = await _httpClient.PostAsync(tokenUrl, content);
        var responseString = await response.Content.ReadAsStringAsync();

        var json = JObject.Parse(responseString);
        string accessToken = json["access_token"]?.ToString();
        string refreshToken = json["refresh_token"]?.ToString();

        return (accessToken, refreshToken);
    }

    public async Task<string> RefreshAccessTokenAsync(string refreshToken)
    {
        string tokenUrl = "https://oauth2.googleapis.com/token";
        var parameters = new Dictionary<string, string>
            {
                { "client_id", _configuration["Authentication:Google:ClientId"] },
                { "client_secret", _configuration["Authentication:Google:ClientSecret"] },
                { "refresh_token", refreshToken },
                { "grant_type", "refresh_token" }
            };

        var content = new FormUrlEncodedContent(parameters);
        var response = await _httpClient.PostAsync(tokenUrl, content);
        var responseString = await response.Content.ReadAsStringAsync();

        var json = JObject.Parse(responseString);
        return json["access_token"]?.ToString();
    }
}
