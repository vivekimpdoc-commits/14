using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AIMeetingAssistant.Core.Models;
using System;

namespace AIMeetingAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DecisionsController : ControllerBase
{
    private static readonly List<Decision> _decisions = new()
    {
        new Decision 
        { 
            Id = 1, 
            DecisionIdStr = "#DEC-901", 
            Description = "Deploy 2 Additional Analysts", 
            TakenBy = "CEO", 
            DateTaken = DateTime.Now.Date, 
            Status = "Implemented", 
            VerifiedBy = "Board",
            MeetingId = 1
        },
        new Decision 
        { 
            Id = 2, 
            DecisionIdStr = "#DEC-902", 
            Description = "Reassign PM for Project Alpha delay", 
            TakenBy = "Marketing Head", 
            DateTaken = DateTime.Now.Date, 
            Status = "Pending Auth", 
            VerifiedBy = "CEO",
            MeetingId = 1
        }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Decision>> GetDecisions()
    {
        return Ok(_decisions);
    }
}
