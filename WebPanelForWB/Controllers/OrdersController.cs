using Microsoft.AspNetCore.Mvc;

namespace WebPanelForWB.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
