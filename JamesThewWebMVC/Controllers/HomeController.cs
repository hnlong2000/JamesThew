using JamesThewWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JamesThewWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(LoginModel model)
		{
			if (model.UserName.Contains("client") && model.Password.Contains("client"))
			{
				TempData["Info"] = "Client";
				return RedirectToAction("Index", "Home", new { area = "Client" });
			}
			return View(model);
		}
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
