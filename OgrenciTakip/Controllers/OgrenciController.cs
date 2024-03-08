using Microsoft.AspNetCore.Mvc;
using OgrenciTakip.Models;
using Microsoft.AspNetCore.Http;

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
            //if (ogrenci.OkulNo < 0)
            //{
            //    return Content("Geçerli bir okul numarası giriniz.");
            //}
            //if (string.IsNullOrEmpty(ogrenci.Isim))
            //{
            //    return Content("Öğrenci adı boş bırakılamaz.");
            //}
            if (ModelState.IsValid == true)
            {
                ogrenciler.Add(ogrenci);
                return RedirectToAction("Index", "Ogrenci");
            }
            else
            {
                return View(ogrenci);
            }
            
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
