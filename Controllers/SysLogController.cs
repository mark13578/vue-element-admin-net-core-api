using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    public class SysLogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
