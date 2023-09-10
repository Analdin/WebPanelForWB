using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Principal;

namespace WebPanelForWB.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class Accounts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        // Добавьте другие DbSet для других сущностей базы данных
    }


}
