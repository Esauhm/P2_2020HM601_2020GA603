using Microsoft.AspNetCore.Mvc;

namespace P2_2020HM601_2020GA603.Controllers
{
    public class CovidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
