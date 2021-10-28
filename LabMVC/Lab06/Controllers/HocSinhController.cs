using Lab06.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Lab06.Controllers
{
	public class HocSinhController : Controller
	{
		// GET: HocSinh
		public ActionResult Index()
		{
			var document = new XmlDocument();
			document.Load(Server.MapPath("~/Assets/HocSinh.xml"));
			var students = new List<HocSinhViewModel>();

			foreach (XmlNode node in document.SelectNodes("/Students/Student"))
			{
				students.Add(new HocSinhViewModel
				{
					Code = node["Code"].InnerText,
					Fullname = node["Fullname"].InnerText,
					Address = node["Address"].InnerText,
					Email = node["Email"].InnerText,
				});
			}

			return View(students);
		}
	}
}