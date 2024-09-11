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
        string SQL = "SELECT * FROM TBL_BASE_TIMETABLE ORDER BY DAYS_CODE, START_TIME";
        SQL_FUNC_CLS.GET_DATA_TABLE_FUNC(SQL, 1);

        var Week_TimeTable = new TIMETABLE_CLS[7, 6];  // 7일 x 6교시
        
        for (int day = 0; day < 7; day++)
        {
            if(day == Convert.ToInt32(SQL_CLS.DT_1.Rows[day]["DAYS_CODE"])){
                // for(int i = 0; i < ){
                    Week_TimeTable[day, i] = new TIMETABLE_CLS
                    {
                        Time = SQL_CLS.DT_1.Rows[i][day].ToString(), 
                        Period = "10:10 ~ 11:00", 
                        Memo = "의료법 기초"
                    };
                }
            }
        }

        var TimeTableDay = new TIMETABLE_WEEK_CLS
        {
            Week_TimeTable = Week_TimeTable
        };

        return View(TimeTableDay);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
