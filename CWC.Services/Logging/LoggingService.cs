using CWC.Domain.Objects.Logging;
using System.IO;
using System.Threading.Tasks;

namespace CWC.Services.Logging
{
    public class LoggingService : ILoggingService
    {
        public const string generalLogging = @"C:\TempStorage\logging.txt";

        public async Task SendMessageToLog(LoggingMessage loggingMessage)
        {
            if (!File.Exists(generalLogging)) return;

            using (StreamWriter sw = File.AppendText(generalLogging))
            {
                await sw.WriteLineAsync("----START MESSAGE----");
                await sw.WriteLineAsync(loggingMessage.MessageFrom);
                await sw.WriteLineAsync(loggingMessage.Message);
                await sw.WriteLineAsync(loggingMessage.DateAdded.ToLongDateString());
                await sw.WriteLineAsync("----END OF MESSAGE----");
            }
        }
    }
}
