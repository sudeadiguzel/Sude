using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int Hour = DateTime.Now.Hour;
           
            ViewBag.Greeting= Hour > 12 ? "İyi Günler." : "Günaydın";
            ViewBag.UserName = "Sude Adıgüzel";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
