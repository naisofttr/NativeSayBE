using NArchitecture.Core.Application.Responses;

namespace Application.Dtos;
public class PromtResponseDto : IResponse
{
    public string Message { get; set; }

    public PromtResponseDto()
    {
        Message = string.Empty;
    }

    public PromtResponseDto(string message)
    {
        Message = message;
    }
}
