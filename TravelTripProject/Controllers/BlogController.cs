using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogComment by = new BlogComment();
        // GET: Blog
        public ActionResult Index()
        {
            by.Deger1 = c.blogs.ToList();
            by.Deger3 = c.blogs.Take(3).OrderByDescending(x=>x.ID).ToList();

            return View(by);
        }

        
        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = c.blogs.Where(x => x.ID == id).ToList();           
            by.Deger2 = c.Comments.Where(x => x.BlogID == id && x.Status == true).ToList();

            return View(by);
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