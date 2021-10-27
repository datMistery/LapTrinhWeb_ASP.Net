using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult DangKyThanhVien()
		{
			return View();
		}

		[HttpGet]
		public ActionResult DangKyKhachHang()
		{
			return View();
		}

		[HttpPost]
		public ActionResult DangKyKhachHang(FormCollection collection)
		{
			ViewBag.Message = "Đăng ký thành công";
			return View();
		}

		public ActionResult HoSoDangKy()
		{
			return View();
		}
	}
}