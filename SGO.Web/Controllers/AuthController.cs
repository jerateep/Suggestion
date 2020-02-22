using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SGO.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login(string user, string pwd)
        {
            bool flglogin = false;
            if (!string.IsNullOrEmpty(user))
            {
                flglogin = true;
            }
            if (flglogin)
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddMinutes(20);
                Response.Cookies.Append("USER", user, cookieOptions);
                return RedirectToAction("MainSGO", "Home");
            }
            return View();
        }
        public IActionResult Logout()
        {
            var user = Request.Cookies["USER"];
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Append("USER", user, cookieOptions);
            return RedirectToAction("Login", "Auth");
        }
    }
}