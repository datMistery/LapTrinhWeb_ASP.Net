using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab06.Models.DAO;

namespace Lab06.Controllers
{
    public class NhaXuatBanController : Controller
    {
        // GET: NhaXuatBan
        public ActionResult Index(int page = 1)
        {
            var nhaXuatBanDAO = new NhaXuatBanDAO();

            ViewBag.Page = page;
            ViewBag.TotalPage = nhaXuatBanDAO.CountTotalPage();

            return View(nhaXuatBanDAO.GetNHAXUATBAN(page));
        }
    }
}