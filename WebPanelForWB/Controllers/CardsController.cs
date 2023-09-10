using Microsoft.AspNetCore.Mvc;

namespace WebPanelForWB.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
