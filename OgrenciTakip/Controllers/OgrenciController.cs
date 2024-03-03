using Microsoft.AspNetCore.Mvc;
using OgrenciTakip.Models;

namespace OgrenciTakip.Controllers
{
    public class OgrenciController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        static List<OgrenciModel> ogrenciler = new List<OgrenciModel>(); 
        
        [HttpGet]
        public IActionResult Kayit(OgrenciModel ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return RedirectToAction("Index","Ogrenci");
        }
        public IActionResult Listele()
        {
            return View(ogrenciler);
        }
        public IActionResult Sil()
        {
            return View();
        }
        public IActionResult Guncelle()
        {
            return View();
        }
    }
}
