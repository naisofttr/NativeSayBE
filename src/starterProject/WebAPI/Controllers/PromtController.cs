using Application.Dtos;
using Application.Features.ChatGBT.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class PromtController : BaseController
{
    [HttpGet("{Promt},{LanguageCode}")]
    public async Task<IActionResult> GetPromt([FromRoute] GetPromtQuery getPromtQuery)
    {
        PromtResponseDto result = await Mediator.Send(getPromtQuery);
        return Ok(result);
    }
}
