using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BlogList()
        {
            var value = c.blogs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog b)
        {
            c.blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }
    }
}