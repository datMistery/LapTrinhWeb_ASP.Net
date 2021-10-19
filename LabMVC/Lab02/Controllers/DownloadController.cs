using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mime;

namespace Lab02.Controllers
{
	public class DownloadController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Download()
		{
			return File(
				fileName: "~/Assets/Lab01.pdf",
				contentType: MediaTypeNames.Application.Pdf,
				fileDownloadName: "Lab01.pdf"
			);
		}
	}
}