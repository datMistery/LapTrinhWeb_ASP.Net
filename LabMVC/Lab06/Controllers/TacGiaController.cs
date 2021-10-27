using Lab06.Models.DAO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lab06.Controllers
{
	public class TacGiaController : Controller
	{
		// GET: TacGia
		public ActionResult Index(
			int page = 1,
			string key = "MaTG",
			string type = "asc"
		)
		{

			var tacGiaDAO = new TacGiaDAO();
			
			ViewBag.Page = page;
			ViewBag.Key = key;
			ViewBag.Type = type;
			ViewBag.TotalPage = tacGiaDAO.CountTotalPage();

            return View(tacGiaDAO.GetTacGia(page, key, type));
        }
    }
}