using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    public class SysMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
