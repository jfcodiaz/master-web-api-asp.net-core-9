
using Microsoft.AspNetCore.Mvc;

namespace MasterNet.webApi.Controllers;

[ApiController]
[Route("demo")]
public class DemoController : ControllerBase
{
    [HttpGet("hello")]
    public IActionResult GetHello()
    {
        return Ok("pakodiaz.dev!");
    }
}
