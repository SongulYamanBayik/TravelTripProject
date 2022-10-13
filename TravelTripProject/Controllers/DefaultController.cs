using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.DTO;
using TravelTripProject.Models.DB;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        BlogComment by = new BlogComment();

        public ActionResult Index()
        {
            by.Deger1 = c.blogs.Where(x => x.TypeID == 1).ToList();
            by.Deger3 = c.blogs.Where(x => x.TypeID == 2).ToList();
            return View(by);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Blog1()
        {

            var deger = c.blogs.OrderBy(x => x.ID).Take(3).ToList();
            return PartialView(deger);
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