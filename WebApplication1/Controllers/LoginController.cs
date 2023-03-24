

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        ProjectPrnContext projectPrnContext = new ProjectPrnContext();
        [HttpGet("/Login")]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost("/Login")]
        public IActionResult Login(Account account)
        {
            Account account1 = projectPrnContext.Accounts.SingleOrDefault(x => x.UserName==account.UserName);
             if(account1 == null|| account1.Password!=account.Password) {
                ViewBag.Message = "sai";    
                return View();
            }
            else
            {
                HttpContext.Session.SetString("user",account.UserName);
                return RedirectToAction("Index", "Home");
            }


        }
    }
}
