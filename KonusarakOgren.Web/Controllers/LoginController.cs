using KonusarakOgren.Web.Data;
using KonusarakOgren.Web.Dto.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KonusarakOgren.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            using (var ctx = new KodDbContext())
            {
                var user = ctx.Users
                    .FirstOrDefault(x => x.Username == dto.Username && x.Password == dto.Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
                }
            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(dto.Username, true);
                return RedirectToAction("index", "home");
            }
        }
    }
}