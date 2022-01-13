using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SystemCommandsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ShutdownController : ControllerBase
{
    [HttpPost(Name = "PostShutdown")]
    public void Post()
    {
        Process.Start("shutdown", "/s /t 0");
    }
}
