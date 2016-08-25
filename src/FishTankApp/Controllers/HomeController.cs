using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FishTankApp.Controllers
{
    public class HomeController : Controller
    {
	    public IActionResult Index()
	    {
		    ViewBag.Title = "Fish tank Dashboard";
		    return View();
	    }
    }
}
