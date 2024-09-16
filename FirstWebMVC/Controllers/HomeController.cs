using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

   public IActionResult Index (string Fullname, string Address)
   {
    string str0utput = "Xin chào" + Fullname+ " đến từ" + Address; 
    ViewBag.Message = str0utput;
    return View();
   }
}