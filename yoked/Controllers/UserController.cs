using Microsoft.AspNetCore.Mvc;
using yoked.Data;

namespace yoked.Controllers
{
    public class UserController : Controller
    {
        private readonly YokedDbContext _db;
        public UserController(YokedDbContext db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
