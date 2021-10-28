using Lab06.Models.DAO;
using Lab06.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab06.Controllers
{
	public class SachController : Controller
	{
		// GET: Sach
		public ActionResult TheoNhaXuatBan(int page = 1, int MaNXB = -1)
		{
			var sachDAO = new SachDAO();

			ViewBag.Page = page;
			ViewBag.MaNXB = MaNXB;
			ViewBag.ToTalPage =
				(MaNXB <= 0) ?
				sachDAO.CountTotalPage() :
				sachDAO.CountTotalPage(x => x.MaNXB == MaNXB);

			return View(sachDAO.GetSachTheoNXB(page, MaNXB));
		}

		public ActionResult TheoChuDe(int page = 1, int MaCD = -1)
		{
			var sachDAO = new SachDAO();

			ViewBag.Page = page;
			ViewBag.MaCD = MaCD;
			ViewBag.ToTalPage =
				(MaCD <= 0) ?
				sachDAO.CountTotalPage() :
				sachDAO.CountTotalPage(x => x.MaCD == MaCD);

			ViewBag.ChuDe = new ChuDeDAO().GetChuDe();

			return View(sachDAO.GetSachTheoChuDe(page, MaCD));
		}

		public ActionResult TheoDonGia(int page = 1, decimal GiaTu = -1, decimal GiaDen = -1)
		{
			var sachDAO = new SachDAO();

			ViewBag.Page = page;
			ViewBag.TotalPage = sachDAO.CountTotalPage(x => x.DonGia >= GiaTu && x.DonGia <= GiaDen);
			ViewBag.GiaTu = GiaTu;
			ViewBag.GiaDen = GiaDen;
			
			return View(sachDAO.GetSachTheoDonGia(page, GiaTu, GiaDen));
		}
	}
}