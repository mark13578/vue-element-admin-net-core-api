using Microsoft.AspNetCore.Mvc;


namespace JMWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSystemInfo()
        {
            // This is a placeholder for the logic from your Spring Boot Controller
            return Ok(new { message = "System is running" });
        }
    }
}
