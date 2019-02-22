using System;

namespace CWC.Domain.Objects.Logging
{
    public class LoggingMessage
    {
        public string MessageFrom { get; set; }
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
