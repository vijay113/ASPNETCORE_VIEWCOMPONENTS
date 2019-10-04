using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCORE_Component.Models;

namespace ASPNETCORE_Component.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int Id=3)
        {          
            //We can Call ViewComponent directly from Controller using following code:-
            //return ViewComponent("CustomNameOfMyPriorityList",new { ItemCount=Id});
            //return ViewComponent("MyPriorityList", new { ItemCount=Id });           
            
             return View();
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
