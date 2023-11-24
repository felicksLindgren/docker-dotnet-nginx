using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace docker_dotnet_nginx.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [AllowAnonymous]
    [HttpGet("live")]
    public IActionResult Live()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

        return Ok(new
        {
            Version = $"{version?.Major}.{version?.Minor}.{version?.Build}",
            Details = versionInfo.ProductVersion
        });
    }
}