using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    public class SysDictController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
