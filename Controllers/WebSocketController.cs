using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    public class WebSocketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
