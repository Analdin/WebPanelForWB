using Microsoft.AspNetCore.Mvc;

namespace WebPanelForWB.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
