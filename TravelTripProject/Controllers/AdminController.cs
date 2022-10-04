﻿using System;
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
            value.Baslik = blog.Baslik;
            value.ImageUrl = blog.ImageUrl;
            value.Tarih = blog.Tarih;
            value.Aciklama = blog.Aciklama;
            value.LikeStatus = blog.LikeStatus;
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        public ActionResult YorumList()
        {
            var value = c.yorumlars.ToList();
            return View(value);
        }
        public ActionResult DeleteYorum(int id)
        {
            var value = c.yorumlars.Find(id);
            c.yorumlars.Remove(value);
            c.SaveChanges();
            return RedirectToAction("YorumList");
        }
        [HttpGet]
        public ActionResult UpdateYorum(int id)
        {
            var value = c.yorumlars.Find(id);
            return View("UpdateBlog", value);
        }
        [HttpPost]
        public ActionResult UpdateYorum(Yorumlar yorumlar)
        {
            var value = c.yorumlars.Find(yorumlar.ID);
            value.KullaniciAdi = yorumlar.KullaniciAdi;
            value.Mail = yorumlar.Mail;
            value.Yorum = yorumlar.Yorum;
            value.Status = yorumlar.Status;
            c.SaveChanges();
            return RedirectToAction("YorumList");
        }
    }
}