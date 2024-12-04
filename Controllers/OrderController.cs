using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
