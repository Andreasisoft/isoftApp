using Microsoft.AspNetCore.Mvc;

namespace isoftApp.Controllers
{
    public class InvoceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
