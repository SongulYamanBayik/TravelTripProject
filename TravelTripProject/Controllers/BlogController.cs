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
        // GET: Blog
        public ActionResult Index()
        {
            var value = c.blogs.ToList();
            return View(value);
        }

        public ActionResult BlogDetay(int id)
        {
            var blogbul = c.blogs.Where(x => x.ID == id).ToList();
            return View(blogbul);
        }
    }
}