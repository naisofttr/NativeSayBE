using Application.Dtos;
using Google.Apis.Auth;
using MediatR;

namespace Application.Features.Auth.Commands.VerifyGoogleToken;
public class VerifyGoogleTokenCommand : IRequest<VerifyGoogleTokenResponse>
{
    public string IdToken { get; set; }

    public VerifyGoogleTokenCommand()
    {
        IdToken = string.Empty;
    }

    public VerifyGoogleTokenCommand(string idToken)
    {
        IdToken = idToken;
    }

    public class VerifyGoogleTokenCommandHandler : IRequestHandler<VerifyGoogleTokenCommand, VerifyGoogleTokenResponse>
    {
        public async Task<VerifyGoogleTokenResponse> Handle(VerifyGoogleTokenCommand request, CancellationToken cancellationToken)
        {
            var response = new VerifyGoogleTokenResponse();
            response.Success = true;
            try
            {
                var payload = await GoogleJsonWebSignature.ValidateAsync(request.IdToken);
            }
            catch (InvalidJwtException ex)
            {
                response.Success = false;
                //response.ErrorMessage = "Invalid ID Token.";
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
