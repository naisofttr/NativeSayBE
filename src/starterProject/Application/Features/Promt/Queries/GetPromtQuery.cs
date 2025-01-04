using Application.Dtos;
using MediatR;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Text.Json;

namespace Application.Features.ChatGBT.Queries;
public class GetPromtQuery : IRequest<PromtResponseDto>
{
    public string Promt { get; set; }
    public string LanguageCode { get; set; }

    public class GetPromtQueryHandler : IRequestHandler<GetPromtQuery, PromtResponseDto>
    {
        private readonly IConfiguration _configuration;
        public GetPromtQueryHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<PromtResponseDto> Handle(GetPromtQuery request, CancellationToken cancellationToken)
        {
            string apiKey = _configuration["OpenAI:ApiKey"];
            string endpoint = _configuration["OpenAI:EndPoint"];

            var client = new RestClient(endpoint);
            var restRequest = new RestRequest();
            restRequest.Method = Method.Post;
            // API Anahtarını Header'a ekleme
            restRequest.AddHeader("Authorization", $"Bearer {apiKey}");
            restRequest.AddHeader("Content-Type", "application/json");
            // API'ye gönderilecek JSON verisi
            var body = new
            {
                model = "gpt-3.5-turbo", // 3.5-turbo veya "gpt-4"
                messages = new[]
                {
                new { role = "system", content = request.LanguageCode + " explanation.Max.50char" },
                new { role = "user", content = request.Promt }
            },
                max_tokens = 100
                ,
                temperature = 0.7
            };
            restRequest.AddJsonBody(body);
            // İstek gönderme ve yanıt alma
            var responseGpt = await client.ExecuteAsync(restRequest);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Büyük-küçük harf duyarlılığını kapatır
            };
            var gbtResponse = JsonSerializer.Deserialize<ChatCompletionDto>(responseGpt.Content, options);

            var response = new PromtResponseDto();
            if (responseGpt.IsSuccessful)
            {
                Console.WriteLine("Response:");
                Console.WriteLine(gbtResponse.Choices[0].Message.Content);
                response.Message = gbtResponse.Choices[0].Message.Content;
            }
            else
            {
                Console.WriteLine("Error Message:");
                Console.WriteLine(responseGpt.Content); // Burada "insufficient_quota" hatasını alırsanız kullanım limitiniz bitmiştir.
            }
            return response;
        }
    }
}
