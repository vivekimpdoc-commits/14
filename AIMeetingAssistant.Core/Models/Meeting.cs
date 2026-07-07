namespace AIMeetingAssistant.Core.Models;

public class Meeting
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Venue { get; set; } = string.Empty;
    public string MeetingType { get; set; } = string.Empty;
    public string Participants { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    
    // AI Generated Fields
    public string? DiscussionSummary { get; set; }
    public string? KeyDecisions { get; set; }
    public string? ImportantInstructions { get; set; }
    public string? PendingIssues { get; set; }
    public string? RiskPoints { get; set; }
}
