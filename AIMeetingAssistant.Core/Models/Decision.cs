using System;

namespace AIMeetingAssistant.Core.Models;

public class Decision
{
    public int Id { get; set; }
    public string DecisionIdStr { get; set; } = string.Empty; // e.g. #DEC-901
    public string Description { get; set; } = string.Empty;
    public string TakenBy { get; set; } = string.Empty; // e.g. SP Officer
    public DateTime DateTaken { get; set; }
    public string Status { get; set; } = "Pending Auth"; // Implemented, Pending Auth
    public string VerifiedBy { get; set; } = string.Empty;
    public int MeetingId { get; set; }
    public Meeting? SourceMeeting { get; set; }
}
