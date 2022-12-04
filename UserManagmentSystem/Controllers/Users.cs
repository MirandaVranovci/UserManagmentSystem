using Microsoft.AspNetCore.Mvc;

namespace UserManagmentSystem.Controllers
{
    public class Users : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
