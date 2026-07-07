using Microsoft.AspNetCore.Mvc;

namespace AIMeetingAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnalyticsController : ControllerBase
{
    [HttpGet("performance")]
    public IActionResult GetPerformanceData()
    {
        var data = new
        {
            AverageTaskCompletion = 87,
            AverageDelayDays = 2.4,
            DecisionCompliance = 91,
            MeetingAttendance = 95,
            DepartmentWiseCompletion = new int[] { 85, 92, 78, 95 },
            TopOfficers = new[]
            {
                new { Name = "Rakesh Kumar", Zone = "Engineering", Completion = 98, Efficiency = 96 },
                new { Name = "Sunita Devi", Zone = "HR", Completion = 92, Efficiency = 90 }
            }
        };

        return Ok(data);
    }
}
