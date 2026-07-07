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
            Title = "Weekly Engineering Review", 
            Date = DateTime.Now.Date,
            Time = new TimeSpan(10, 0, 0),
            Venue = "HQ, Conference Room A",
            MeetingType = "Review",
            Participants = "CEO, CTO, VP Product",
            Agenda = "Review of pending deliverables and upcoming Q3 launch",
            DiscussionSummary = "Discussed stakeholder presentation requirements for next week and backlog of 15 pending tickets in Engineering.",
            KeyDecisions = "Deploy 2 additional engineers to QA. PMs given 48 hours to update Jira.",
            RiskPoints = "Shortage of business analysts for Q3 planning."
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
