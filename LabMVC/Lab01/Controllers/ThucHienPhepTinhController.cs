using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
	public class ThucHienPhepTinhController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Plus()
		{
			var a = float.Parse(Request.QueryString["A"]);
			var b = float.Parse(Request.QueryString["B"]);
			return Json(a + b, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Minus()
		{
			var a = float.Parse(Request.QueryString["A"]);
			var b = float.Parse(Request.QueryString["B"]);
			return Json(a - b, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Multiply()
		{
			var a = float.Parse(Request.QueryString["A"]);
			var b = float.Parse(Request.QueryString["B"]);
			return Json(a * b, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Divide()
		{
			var a = float.Parse(Request.QueryString["A"]);
			var b = float.Parse(Request.QueryString["B"]);

			if (b == 0)
			{
				return Json("Số nhập vào không hợp lệ", JsonRequestBehavior.AllowGet);
			}

			return Json(a / b, JsonRequestBehavior.AllowGet);
		}
	}
}