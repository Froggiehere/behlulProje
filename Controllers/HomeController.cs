using Microsoft.AspNetCore.Mvc;

using behlul.Models;

namespace behlul.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult Hakkımızda()
        {
            return View();
        }
        public IActionResult Etkinlikler()
        {
            Context c = new Context();
            var bilgiler = c.etkinliklers.ToList();
            return View(bilgiler);
        }
    }
}
