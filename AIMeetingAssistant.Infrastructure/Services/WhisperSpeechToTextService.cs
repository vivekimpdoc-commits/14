using System.IO;
using System.Threading.Tasks;
using AIMeetingAssistant.Core.Interfaces;

namespace AIMeetingAssistant.Infrastructure.Services;

public class WhisperSpeechToTextService : ISpeechToTextService
{
    public WhisperSpeechToTextService()
    {
    }

    public Task<string> TranscribeAudioAsync(Stream audioStream, string language = "hi")
    {
        // Stub implementation calling Whisper model for English + Hindi mixed audio
        return Task.FromResult("यह एक सैंपल ट्रांसक्रिप्ट है। (This is a sample transcript.)");
    }
}
