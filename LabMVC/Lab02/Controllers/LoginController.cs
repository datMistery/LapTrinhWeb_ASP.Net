using System.Web.Mvc;

namespace Lab02.Controllers
{
	public class LoginController : Controller
	{
		// GET: Login
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Login(string username, string password)
		{
			TempData["Username"] = username;
			if (username == "pheti" && password == "123456")
			{
				return RedirectToRoute(new
				{
					controller = "Welcome",
					action = "Index",
					username = username
				});
			}

			TempData["Error"] = "Tên đăng nhập hoặc mật khẩu không hợp lệ";
			return RedirectToAction("Index");
		}
	}
}