using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_Login2.Controllers
{
    [Authorize]
    public class PhanQuyenController : Controller
    {
        // GET: PhanQuyen
        public ActionResult Index()
        {
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;

            ViewBag.Name = userClaims?.FindFirst("name")?.Value;
            ViewBag.Username = userClaims?.FindFirst("preferred_username")?.Value;
            ViewBag.SurName = userClaims?.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname")?.Value;
            ViewBag.GivenName = userClaims?.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname")?.Value;
            return View();
        }
    }
}