using System.Threading.Tasks;

namespace AIMeetingAssistant.Core.Interfaces;

public interface IAISummarizationService
{
    Task<string> GenerateMeetingMinutesAsync(string transcript);
    Task<string> ExtractTasksAsync(string transcript);
    Task<string> ExtractKeyDecisionsAsync(string transcript);
    Task<string> DetectRisksAsync(string transcript);
}
