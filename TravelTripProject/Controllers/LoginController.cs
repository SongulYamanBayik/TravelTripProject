using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.DB;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var value = c.admins.FirstOrDefault(x => x.USerName == admin.USerName && x.Password == admin.Password);
            if (value!=null)
            {
                FormsAuthentication.SetAuthCookie(value.USerName, false);
                Session["UserName"] = value.USerName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();

            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}