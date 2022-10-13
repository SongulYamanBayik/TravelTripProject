using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.DB;
using TravelTripProject.Models.DTO;

namespace TravelTripProject.Controllers
{
    public class RouteController : Controller
    {
        Context c = new Context();
        BlogComment bc = new BlogComment();
        // GET: Route
        public ActionResult Index()
        {
            bc.Deger1 = c.blogs.Where(x => x.TypeID == 2).ToList();
            bc.Deger3 = c.blogs.Where(x => x.TypeID == 2).Take(3).OrderByDescending(x => x.ID).ToList();
            bc.Deger4 = c.Comments.Where(x => x.Status == true).Take(3).OrderByDescending(x => x.ID).ToList();

            return View(bc);
        }

        public ActionResult Detay(int id)
        {
            bc.Deger1 = c.blogs.Where(x => x.ID == id).ToList();
            bc.Deger2 = c.Comments.Where(x => x.BlogID == id && x.Status == true).ToList();
            bc.Deger3 = c.blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            bc.Deger4 = c.Comments.Where(x => x.Status == true).Take(3).OrderByDescending(x => x.ID).ToList();
            return View(bc);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.a = id;

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Comment y)
        {
            c.Comments.Add(y);

            c.SaveChanges();

            return PartialView();
        }
    }
}