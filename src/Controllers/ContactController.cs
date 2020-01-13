using Microsoft.AspNetCore.Mvc;
using pieshop.Models;

namespace pieshop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}