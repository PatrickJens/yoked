using Microsoft.AspNetCore.Mvc;

namespace yoked.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
