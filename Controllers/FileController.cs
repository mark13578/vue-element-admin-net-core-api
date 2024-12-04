using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
