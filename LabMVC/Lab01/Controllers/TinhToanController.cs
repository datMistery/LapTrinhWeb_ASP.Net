using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
	public class TinhToanController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Calulate()
		{
			var unitPrice = float.Parse(Request.QueryString["unit-price"]);
			var quantity = float.Parse(Request.QueryString["quantity"]);

			return Json(unitPrice * quantity, JsonRequestBehavior.AllowGet);
		}
	}
}