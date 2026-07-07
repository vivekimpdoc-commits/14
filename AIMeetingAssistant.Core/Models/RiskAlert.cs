using System;

namespace AIMeetingAssistant.Core.Models;

public class RiskAlert
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Level { get; set; } = "Medium"; // High, Medium, Low
    public string Category { get; set; } = "Resource Shortage";
    public string AIRecommendation { get; set; } = string.Empty;
    public DateTime DetectedOn { get; set; }
    public int SourceMeetingId { get; set; }
}
