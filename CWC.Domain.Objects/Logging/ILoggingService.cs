using System.Threading.Tasks;

namespace CWC.Domain.Objects.Logging
{
    public interface ILoggingService
    {
        Task SendMessageToLog(LoggingMessage loggingMessage);
    }
}