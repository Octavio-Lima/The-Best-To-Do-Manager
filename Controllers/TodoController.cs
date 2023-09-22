using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using The_Best_To_Do_Manager.Models;

namespace The_Best_To_Do_Manager.Controllers;

public class TodoController : Controller
{
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    public IActionResult ListAsync(string name)
    {
        ViewBag.Message = ListData.GetDataAsync(name);
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
