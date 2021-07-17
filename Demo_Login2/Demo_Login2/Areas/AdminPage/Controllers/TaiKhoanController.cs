using Demo_Login2.Areas.AdminPage.Business;
using Demo_Login2.Models.DTO;
using Demo_Login2.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_Login2.Areas.AdminPage.Controllers
{
    public class TaiKhoanController : Controller
    {
        public ActionResult LayTaiKhoan(int id)
        {
            using (TaiKhoanBusiness bs = new TaiKhoanBusiness())
            {
                AccountDTO acc = bs.LayTaiKhoan(id);
                return View("Index",acc);
            }
        }
        public ActionResult LayDanhSachTaiKhoan(dynamic dynamic)
        {
            using (TaiKhoanBusiness bs = new TaiKhoanBusiness())
            {
                return View("Index",bs.LayDanhSachTaiKhoan());
            }
        }

        public ActionResult ThemTaiKhoan(AccountDTO taikhoan)
        {
            using (TaiKhoanBusiness bs = new TaiKhoanBusiness())
            {
                return View("Index",bs.ThemTaiKhoan(taikhoan));
            }
        }

        public ActionResult XoaTaiKhoan(int id)
        {
            using (TaiKhoanBusiness bs = new TaiKhoanBusiness())
            {
                var result = bs.XoaTaiKhoan(id);
                if (result)
                    return View("Successed");
                else
                    return View("Failed");
            }
        }

        public ActionResult SuaTaiKhoan(AccountDTO taikhoan)
        {
            using (TaiKhoanBusiness bs = new TaiKhoanBusiness())
            {
                return View("Index", bs.SuaTaiKhoan(taikhoan));
            }
        }
    }
}