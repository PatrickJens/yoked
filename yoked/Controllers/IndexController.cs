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
    }
}
