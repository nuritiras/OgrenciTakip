using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakip.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gonder() 
        {
            return RedirectToAction("Index");
        }
    }
}
