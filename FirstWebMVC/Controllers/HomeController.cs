using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();  
    }
}


  