using Microsoft.AspNetCore.Mvc;
using Yummy.Models;

namespace Yummy.Areas.manage.Controllers
{
    public class SliderController : Controller
    {
        private readonly DataContext _datacontext;

        public SliderController(DataContext dataContext)
        {
            _datacontext = dataContext;
        }
        public IActionResult Index()
        {
            List<Slider> sliderList = _datacontext.Sliders.ToList();
            return View(sliderList);
        }
    }
}
