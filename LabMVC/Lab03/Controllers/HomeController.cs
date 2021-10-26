using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03.Models;
using System.IO;

namespace Lab03.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult DiaDanhDuLich()
		{
			ViewData["PlaceNames"] = new string[]
			{
				"Vịnh Hạ Long",
				"Phan Thiết - Mũi Né",
				"Đà Lạt",
				"Nha Trang",
				"Vũng Tàu",
			};
			return View();
		}

		public ActionResult ThongTinCaNhan()
		{
			return View();
		}

		public ActionResult DangKy(FormCollection collection)
		{
			TempData["User"] = new User
			{
				Name = collection["txtTen"],
				Gender = collection["GioiTinh"],
				English = collection["chkAnhVan"],
				French = collection["chkPhapVan"],
				Income = collection["ThuNhap"],
				Level = collection["TrinhDo"],
			};
			return RedirectToAction("ThongTinCaNhan");
		}

		[HttpGet]
		public ActionResult UploadFile()
		{
			return View();
		}

		[HttpPost]
		public ActionResult UploadFile(HttpPostedFileBase file)
		{
			try
			{
				if (file.ContentLength > 0)
				{
					string _FileName = Path.GetFileName(file.FileName);
					string _path = Path.Combine(Server.MapPath("~/Upload"), _FileName);
					file.SaveAs(_path);
				}
				ViewBag.Message = "File Uploaded Successfully!!";
				return View();
			}
			catch(Exception e)
			{
				ViewBag.Message = $"Error: ${e.Message}";
				return View();
			}
		}

		public ActionResult DocBao()
		{
			return View();
		}

		[HttpGet]
		public ActionResult HoSoDangKy()
		{
			return View();
		}

		[HttpPost]
		public ActionResult HoSoDangKy(FormCollection collection)
		{
			var information = new Information();
			information.FullName = collection["fullname"];
			information.Email = collection["email"];
			information.Address = collection["address"];
			information.Gender = collection["gender"];
			information.Phone = collection["phone"];

			return View(information);
		}
	}
}