using Microsoft.AspNetCore.Mvc;

namespace pieshop.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			return View();
		}
	}
}