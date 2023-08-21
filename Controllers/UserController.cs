using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Empty.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
