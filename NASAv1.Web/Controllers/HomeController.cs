using Microsoft.AspNetCore.Mvc;

namespace NASAv1.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}