using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DSM.Models;

namespace DSM.Controllers;

public class NotionController : Controller
{
    private readonly ILogger<NotionController> _logger;

    public NotionController(ILogger<NotionController> logger)
    {
        _logger = logger;
    }
    public async Task<IActionResult> Create(BOARD_POST_CLS post)
    {
        if (ModelState.IsValid)
        {
            // Notion에 자료 이식
            var notionService = new NotionService();
            await notionService.AddPageToNotion(post.Title, post.Content);
            Console.WriteLine(post.Content);
            return RedirectToAction("Index","Home");
        }
        return View(post);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

