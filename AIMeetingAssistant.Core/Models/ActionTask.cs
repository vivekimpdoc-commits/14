using System;

namespace AIMeetingAssistant.Core.Models;

public class ActionTask
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int AssignedOfficerId { get; set; }
    public Officer? AssignedOfficer { get; set; }
    public string Priority { get; set; } = "Medium"; // High, Critical, Medium, Low
    public DateTime DueDate { get; set; }
    public string Status { get; set; } = "Pending"; // Pending, In Progress, Completed
    public int ProgressPercentage { get; set; }
    public int MeetingId { get; set; }
    public Meeting? SourceMeeting { get; set; }
}
