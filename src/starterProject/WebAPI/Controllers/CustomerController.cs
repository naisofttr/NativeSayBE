using Application.Features.Customers.Commands.Create;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class CustomerController : BaseController
{
    [HttpPost("CreateCustomer")]
    public async Task<IActionResult> Add([FromBody] CreateCustomerCommand createCustomerCommand)
    {
        CreatedCustomerResponse result = await Mediator.Send(createCustomerCommand);
        return Created(uri: "", result);
    }
}
