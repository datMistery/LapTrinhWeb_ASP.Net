using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
	public class StatisticController : Controller
	{
		public ActionResult Index()
		{
			//Todo: Read from database
			ViewBag.NoOnlineUser = 5;
			ViewBag.TotalAccess = 2796;
			return View();
		}
	}
}