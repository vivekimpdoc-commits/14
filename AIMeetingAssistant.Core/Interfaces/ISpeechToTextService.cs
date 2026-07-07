using System.IO;
using System.Threading.Tasks;

namespace AIMeetingAssistant.Core.Interfaces;

public interface ISpeechToTextService
{
    Task<string> TranscribeAudioAsync(Stream audioStream, string language = "hi");
}
