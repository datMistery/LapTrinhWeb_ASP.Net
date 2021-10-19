using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
	public class WelcomeController : Controller
	{
		public ActionResult Index(string username)
		{
			ViewBag.Username = username;
			return View();
		}
	}
}