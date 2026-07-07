using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIMeetingAssistant.Core.Models;
using System;

namespace AIMeetingAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private static readonly List<ActionTask> _tasks = new()
    {
        new ActionTask 
        { 
            Id = 1, 
            Title = "Update Q3 Financial Report", 
            Description = "Project Alpha needs immediate attention before stakeholder pitch.",
            AssignedOfficerId = 1,
            Priority = "High",
            DueDate = DateTime.Now.AddDays(3),
            Status = "Pending",
            ProgressPercentage = 30,
            MeetingId = 1
        },
        new ActionTask 
        { 
            Id = 2, 
            Title = "Prepare Client Presentation", 
            Description = "Global Tech Pitch requires slides on Q2 metrics.",
            AssignedOfficerId = 2,
            Priority = "Critical",
            DueDate = DateTime.Now.AddDays(1),
            Status = "In Progress",
            ProgressPercentage = 60,
            MeetingId = 1
        }
    };

    [HttpGet]
    public ActionResult<IEnumerable<ActionTask>> GetTasks()
    {
        return Ok(_tasks);
    }

    [HttpGet("{id}")]
    public ActionResult<ActionTask> GetTask(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
            return NotFound();

        return Ok(task);
    }

    [HttpPost]
    public ActionResult<ActionTask> CreateTask([FromBody] ActionTask task)
    {
        task.Id = _tasks.Count + 1;
        _tasks.Add(task);
        return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
    }
}
