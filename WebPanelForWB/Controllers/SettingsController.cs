using Microsoft.AspNetCore.Mvc;

namespace WebPanelForWB.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
