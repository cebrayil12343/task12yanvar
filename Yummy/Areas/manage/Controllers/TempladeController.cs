using Microsoft.AspNetCore.Mvc;
using Yummy.Models;

namespace Yummy.Areas.manage.Controllers
{
    [Area("manage")]
    public class TempladeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Creat(Slider slider)
        {
            return View();
        }
    }
}
