using Microsoft.AspNetCore.Mvc;

namespace cv.uı.Areas.User.Controllers
{
    public class DefaultController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult scripts()
        {
            return PartialView();
        }
        public PartialViewResult head()
        {
            return PartialView();
        }
        public PartialViewResult nav()
        {
            return PartialView();
        }
        public PartialViewResult footer()
        {
            return PartialView();
        }
    }
}
