using Microsoft.AspNetCore.Mvc;
using pieshop.Models;

namespace pieshop.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPieRepository _pieRepository;

		public HomeController(IPieRepository pieRepository)
		{
			_pieRepository = pieRepository;
		}

		public ViewResult Index()
		{
			var homeViewModel = new HomeViewModel
			{
				PiesOfTheWeek = _pieRepository.PiesOfTheWeek
			};

			return View(homeViewModel);
		}
	}
}