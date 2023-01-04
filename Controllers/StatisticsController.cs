using Microsoft.AspNetCore.Mvc;

namespace HIN_Ventures.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
