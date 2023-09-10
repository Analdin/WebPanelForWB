using Microsoft.AspNetCore.Mvc;

namespace WebPanelForWB.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
