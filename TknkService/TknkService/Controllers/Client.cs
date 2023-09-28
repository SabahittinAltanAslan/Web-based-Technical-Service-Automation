
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TknkService.Models;
namespace TknkService.Controllers
{
    public class Client : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.musteris.Include(x=>x.chz).ToList();
            return View(degerler);
        }
        public IActionResult MusteriSil(int id)
        {
            var mus = c.musteris.Find(id);
            c.musteris.Remove(mus);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MusteriGetir(int id)
        {
            var mus = c.musteris.Find(id);
            return View("MusteriGetir", mus);
        }
        public IActionResult MusteriGuncelle(Musteri m)
        {
            var chz = c.musteris.Find(m.Musteriid);
            chz.ad = m.ad;
            chz.soyad = m.soyad;
            chz.adres = m.adres;
            chz.telefon = m.telefon;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MusteriBilgileri(int id)
        {
            var mus = c.musteris.Where(x=>x.Musteriid==id).ToList();
            var x = c.musteris.Where(x=>x.Musteriid==id).Select(y=>y.chz).ToList();
            return View(mus);
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }
    }
}
