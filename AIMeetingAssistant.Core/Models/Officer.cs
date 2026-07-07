namespace AIMeetingAssistant.Core.Models;

public class Officer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
    public string Zone { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public int TaskCompletionRate { get; set; }
    public double ResponseTimeDays { get; set; }
    public int AIEfficiencyScore { get; set; }
}
