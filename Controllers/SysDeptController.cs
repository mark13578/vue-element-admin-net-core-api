using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    public class SysDeptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
