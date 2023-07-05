using System.Diagnostics;
using DevWeb_Trab_Final.Data;
using DevWeb_Trab_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevWeb_Trab_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DevWeb_Trab_FinalContext _dbContext; 

        public HomeController(ILogger<HomeController> logger, DevWeb_Trab_FinalContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var funcionarios = _dbContext.Funcionarios.ToList(); 

            return View("Index",funcionarios);
        }

        public IActionResult Privacy()
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
