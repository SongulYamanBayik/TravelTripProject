using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.DB;

namespace TravelTripProject.Controllers
{
    [Authorize]

    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.a = c.blogs.Where(x=>x.TypeID==1).Count();
            ViewBag.b = c.Comments.Count();
            ViewBag.c = c.blogs.Where(x => x.TypeID == 2).Count();
            ViewBag.d = c.Comments.Where(x => x.Status == true).Count();
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

        public ActionResult DeleteBlog(int id)
        {
            var value = c.blogs.Find(id);
            c.blogs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var value = c.blogs.Find(id);
            return View("UpdateBlog",value);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var value = c.blogs.Find(blog.ID);
            value.Title = blog.Title;
            value.ImageUrl = blog.ImageUrl;
            value.Date = blog.Date;
            value.Description = blog.Description;
            value.LikeStatus = blog.LikeStatus;
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        public ActionResult YorumList()
        {
            var value = c.Comments.ToList();
            return View(value);
        }
        public ActionResult DeleteYorum(int id)
        {
            var value = c.Comments.Find(id);
            c.Comments.Remove(value);
            c.SaveChanges();
            return RedirectToAction("YorumList");
        }
        [HttpGet]
        public ActionResult UpdateYorum(int id)
        {
            var value = c.Comments.Find(id);
            return View("UpdateYorum", value);
        }
        [HttpPost]
        public ActionResult UpdateYorum(Comment yorumlar)
        {
            var value = c.Comments.Find(yorumlar.ID);
            value.UserName = yorumlar.UserName;
            value.Mail = yorumlar.Mail;
            value.CommentDetail = yorumlar.CommentDetail;
            value.Status = yorumlar.Status;
            c.SaveChanges();
            return RedirectToAction("YorumList");
        }
    }
}