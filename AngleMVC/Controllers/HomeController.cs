using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngleMVC.Models;
using AngleWinForms;

namespace AngleMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Entry entry)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            try
            {
                DateTime time = DateTime.Parse(entry.Time);

                String.Format("{0:HH:mm}", time);

                int angle = Utilities.GetAngle(Utilities.HoursToZeroAngle(time.Hour), Utilities.MinutesToZeroAngle(time.Minute));
                ViewBag.Angle = $"{angle.ToString()}° / {(360 - angle).ToString()}°";
            }
            catch
            {
                ViewBag.Angle = "Wprowadź prawidłową godzinę";
            }
            
            return View();
        }


    }
}