using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using TknkService.Models;

namespace TknkService.Controllers
{
    public class Cihazlar : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.cihazs.ToList();
            return View(degerler);
        }
        public IActionResult CihazSil(int id)
        {
            var chz = c.cihazs.Find(id);
            c.cihazs.Remove(chz);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CihazGetir(int id)
        {
            var chz = c.cihazs.Find(id);
            return View("CihazGetir", chz);
        }
        public IActionResult CihazGuncelle(Cihaz h)
        {
            var chz = c.cihazs.Find(h.cihazID);
            chz.cihazAd = h.cihazAd;
            chz.aciklama = h.aciklama;
            chz.cihazDurum = h.cihazDurum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CihazBilgileri(int id)
        {
            var mus = c.cihazs.Where(x => x.cihazID == id).ToList();
            return View(mus);
        }
    }
}
