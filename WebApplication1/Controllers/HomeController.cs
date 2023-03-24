using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        ProjectPrnContext projectPrnContext = new ProjectPrnContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Table> list = projectPrnContext.Tables.ToList();
            
            return View(list);
        }
        [HttpGet("/OrderDetail/{id?}")]
        public ActionResult OrderDetail(int id)
        {
            List<OrderDetail> list= projectPrnContext.OrderDetails.Include(x=>x.IdOrderNavigation).Include(x=>x.IdFoodNavigation)
                .Where(x=>x.IdOrderNavigation.StatusId==4).ToList();

            return View(list);

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