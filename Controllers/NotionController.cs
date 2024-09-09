using Microsoft.AspNetCore.Mvc;
using DSM.Models;

namespace DSM.Controllers
{
    public class NotionController : Controller
    {
        private readonly NotionService _notionService;

        public NotionController(NotionService notionService)
        {
            _notionService = notionService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPage(BOARD_POST_CLS BOARD_POST_CLS)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", BOARD_POST_CLS);
            }

            try
            {
                await _notionService.AddPageToNotion(BOARD_POST_CLS.Title, BOARD_POST_CLS.Content);
                ViewBag.Message = "Page successfully added to Notion!";
                return View("Create", new BOARD_POST_CLS()); // Clear form after success
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error: {ex.Message}";
                return View("Create", BOARD_POST_CLS);
            }
        }
    }
}
