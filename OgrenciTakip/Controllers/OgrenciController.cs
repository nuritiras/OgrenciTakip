using Microsoft.AspNetCore.Mvc;
using OgrenciTakip.Models;

namespace OgrenciTakip.Controllers
{
    public class OgrenciController : Controller
    {
        static List<OgrenciModel> ogrenciler = new List<OgrenciModel>();


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Kayit(OgrenciModel ogrenci)
        {
            if (ModelState.IsValid == true)
            {
                ogrenciler.Add(ogrenci);
            }
            return View();
        }
        public IActionResult Listele()
        {
            return View(ogrenciler);
        }

        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Giris(OgrenciModel ogrenci)
        {
            foreach (var item in ogrenciler)
            {
                if (item.OkulNo == ogrenci.OkulNo &&
                    item.IsimSoyisim == ogrenci.IsimSoyisim &&
                    item.Sinifi == ogrenci.Sinifi)
                {
                    return RedirectToAction("Listele", "Ogrenci");
                }
                else
                {
                    return Content("Bilgiler uyuşmuyor!");
                }
            }
            return View();
        }
    }
}
