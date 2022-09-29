using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.blogs.ToList();
            return View(value);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Blog1()
        {

            //bu kısım blog değil turlar hakkında bilgi veren bir alan olsun ders 24
            return PartialView();
        }

        public PartialViewResult OurBestPlaces1()
        {
            var value = c.blogs.Where(x => x.LikeStatus == true).Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult OurBestPlaces2()
        {
            var value = c.blogs.Where(x => x.LikeStatus == true).OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(value);
        }
    }
}