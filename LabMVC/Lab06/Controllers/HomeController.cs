using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab06.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DanhSachTacGia()
        {
            return View();
        }
        
        public ActionResult DanhSachNhaXuatBan()
        {
            return View();
        }
        
        public ActionResult DanhSachSach()
        {
            return View();
        }
    }
}