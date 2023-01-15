using Microsoft.AspNetCore.Mvc;

namespace PwnedPhysics.Controllers;

[ApiController]
public class VerifyController : ControllerBase
{
    [Route("verify")]
    public string Verify([FromQuery] string? code)
    {
        return $"{code}verified";
    }
}