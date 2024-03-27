using Microsoft.AspNetCore.Mvc;

namespace MIST_353_Group_API.Controllers
{
    public class Weather : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
