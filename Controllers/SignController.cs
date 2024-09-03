using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DSM.Models;

namespace DSM.Controllers;

public class SignController : Controller
{
    private readonly ILogger<SignController> _logger;

    public SignController(ILogger<SignController> logger)
    {
        _logger = logger;
    }

    public IActionResult SignIn()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
