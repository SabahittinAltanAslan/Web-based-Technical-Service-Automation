using Microsoft.AspNetCore.Mvc;
using TknkService.Models;

namespace TknkService.Controllers
{
    public class MusteriCihazEkle : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri([Bind(Prefix = "Item1")] Cihaz Model1, [Bind(Prefix = "Item2")] Musteri Model2)
        {
            //CİHAZ İD LAIP MODEL 2 EKLİCEM....
            c.cihazs.Add(Model1);
            c.SaveChanges();
            c.musteris.Add(Model2);
            c.SaveChanges();
            return RedirectToAction("/Cihazlar/Index/");
        }
    }
}
