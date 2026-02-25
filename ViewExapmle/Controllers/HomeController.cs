using Microsoft.AspNetCore.Mvc;

namespace ViewExapmle.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
