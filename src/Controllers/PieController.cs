using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pieshop.Models;

namespace pieshop.Controllers
{
	public class PieController : Controller
	{
			private readonly IPieRepository _pieRepository;
			private readonly ICategoryRepository _categoryRepository;

			public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
			{
				_pieRepository = pieRepository;
				_categoryRepository = categoryRepository;
			}

			public ViewResult List(string category)
			{
				IEnumerable<Pie> pies;
				string currentCategory;

				if(string.IsNullOrEmpty(category))
				{
					pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
					currentCategory = "All Pies";
				}
				else
				{
					pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
						.OrderBy(p => p.PieId);
					currentCategory = category;
				}

				return View(
					new PieListViewModel
					{
						Pies = pies,
						CurrentCategory = currentCategory
					}
				);
			}

			public IActionResult Details(int id)
			{
				var pie = _pieRepository.GetPieById(id);

				if(pie == null)				
					return NotFound();	
			
				return View(pie);
			}
    }
}