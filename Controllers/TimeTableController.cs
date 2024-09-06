using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DSM.Models;

namespace DSM.Controllers;

public class TimeTableController : Controller
{
    private readonly ILogger<TimeTableController> _logger;

    public TimeTableController(ILogger<TimeTableController> logger)
    {
        _logger = logger;
    }

    public IActionResult TimeTable()
    {    
        var TimeTableDay = new List<TIMETABLE_CLS>{
            new TIMETABLE_CLS { Time = "2교시", Period = "10:10 ~ 11:00", Memo = "의료법 기초"},
            new TIMETABLE_CLS { Time = "3교시", Period = "11:00 ~ 12:00", Memo = "의료법 기초"},
            new TIMETABLE_CLS { Time = "4교시", Period = "12:00 ~ 12:50", Memo = "의료법 기초"},
            new TIMETABLE_CLS { Time = "점심", Period = "13:00 ~ ", Memo = "식단표"},
            new TIMETABLE_CLS { Time = "6교시", Period = "15:10 ~ 16:00", Memo = "말하기와 사고"},
            new TIMETABLE_CLS { Time = "7교시", Period = "16:00 ~ 16:50", Memo = "말하기와 사고"},
        };

        return View(TimeTableDay);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
