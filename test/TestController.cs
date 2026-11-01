using Microsoft.AspNetCore.Mvc;

namespace receipt_engine_API.test;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHolaMundo")]
    public IActionResult Get()
    {
        _logger.LogInformation("Ejecutando endpoint de prueba");
        
        return Ok(new { status = 200, mensaje = "receipt engine API" });
    }
}
