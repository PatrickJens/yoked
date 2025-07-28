using Microsoft.AspNetCore.Mvc;

namespace yoked.Controllers
{
    public class IndexController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
            
        }
        [Route("/Index/Login/")]
        public String Login()
        {
            return "Main App";
        }
        [Route("/Index/CreateUser/")]
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }

    }
}
