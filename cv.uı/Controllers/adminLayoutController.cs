using Microsoft.AspNetCore.Mvc;

namespace cv.uı.Controllers
{
    public class adminLayoutController : Controller
    {
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
        public PartialViewResult navbar()
        {
            return PartialView();
        }
    }
}
