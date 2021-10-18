using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
	public class DefaultController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Plus()
		{
			var n = float.Parse(Request.QueryString["n"]);
			var m = float.Parse(Request.QueryString["m"]);
			return Json(m + n, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Minus()
		{
			var n = float.Parse(Request.QueryString["n"]);
			var m = float.Parse(Request.QueryString["m"]);
			return Json(n - m, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Multiply()
		{
			var n = float.Parse(Request.QueryString["n"]);
			var m = float.Parse(Request.QueryString["m"]);
			return Json(n * m, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Divide()
		{
			var n = float.Parse(Request.QueryString["n"]);
			var m = float.Parse(Request.QueryString["m"]);
			return Json(n / m, JsonRequestBehavior.AllowGet);
		}
	}
}