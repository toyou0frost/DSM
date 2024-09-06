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
            new TIMETABLE_CLS { SubjectName = "말하기와 사고", ProfessorName = "Mr. Kim" },
            new TIMETABLE_CLS { SubjectName = "임상병리 기초", ProfessorName = "Ms. Lee" },
            new TIMETABLE_CLS { SubjectName = "임상병리 기초", ProfessorName = "Ms. Lee" },
            new TIMETABLE_CLS { SubjectName = "임상병리 기초", ProfessorName = "Ms. Lee" },
        };

        return View(TimeTableDay);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
