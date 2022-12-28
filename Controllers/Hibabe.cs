using HibaJelentes.Models;
using Microsoft.AspNetCore.Mvc;

namespace HibaJelentes.Controllers
{
    public class Hibabe : Controller
    {
        public IActionResult Index()
        {
            Adatok a = new();
            Table t = new ();
            t.Irszam = Request.Form["irszam"];
            t.Varos = Request.Form["varos"];
            t.Utca = Request.Form["utca"];
            t.Datum = DateTime.Now;
            a.Tables.Add(t);
            a.SaveChanges();

            HibaModell hm = new();
            hm.Hiba = Request.Form["irszam"];
            return View(hm);
        }
    }
}
