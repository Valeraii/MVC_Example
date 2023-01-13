using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Example.Models;

namespace MVC_Example.Controllers;

//Name of controller
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    //constructor
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        ViewData["days"] = days;
        return View();
    }

    public IActionResult Privacy()
    {
        //returns home/index.cshtml
        return View();
    }

    public IActionResult Bogus()
    {
        //Viewdata and Viewbag are interchangeable 
        ViewData["author"] = "John Cena";
        ViewBag.Date = DateTime.Now;
        string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        return View(days);
    }

    //called if error
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
