﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
	public class DefaultController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}