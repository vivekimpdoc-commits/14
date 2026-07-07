using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AIMeetingAssistant.Core.Models;
using System;

namespace AIMeetingAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MeetingsController : ControllerBase
{
    // Mock data for demonstration purposes without DB connection
    private static readonly List<Meeting> _meetings = new()
    {
        new Meeting 
        { 
            Id = 1, 
            Title = "Weekly Law & Order Review", 
            Date = DateTime.Now.Date,
            Time = new TimeSpan(10, 0, 0),
            Venue = "SP Office, Conference Room A",
            MeetingType = "Review",
            Participants = "SP, ASP, CO City",
            Agenda = "Review of pending investigations and upcoming VIP movement",
            DiscussionSummary = "Discussed VIP security arrangements for next week and backlog of 15 pending cases in City Zone.",
            KeyDecisions = "Deploy 2 additional QRTs at main venue. IOs given 48 hours to submit case diaries.",
            RiskPoints = "Shortage of female constables for VIP duty."
        }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Meeting>> GetMeetings()
    {
        return Ok(_meetings);
    }

    [HttpGet("{id}")]
    public ActionResult<Meeting> GetMeeting(int id)
    {
        var meeting = _meetings.Find(m => m.Id == id);
        if (meeting == null)
            return NotFound();

        return Ok(meeting);
    }

    [HttpPost]
    public ActionResult<Meeting> CreateMeeting([FromBody] Meeting meeting)
    {
        meeting.Id = _meetings.Count + 1;
        _meetings.Add(meeting);
        return CreatedAtAction(nameof(GetMeeting), new { id = meeting.Id }, meeting);
    }
}
