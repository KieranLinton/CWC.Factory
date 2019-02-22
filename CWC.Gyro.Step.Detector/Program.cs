using CWC.Domain.Objects.Logging;
using CWC.Services.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CWC.Gyro.Step.Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up dependicys
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddSingleton<ILoggingService, LoggingService>()
                .BuildServiceProvider();

            // create loggin service pipeline
            ILoggingService logginService = serviceProvider.GetService<ILoggingService>();

            // create message to output 
            LoggingMessage loggingMessage = new LoggingMessage
            {
                DateAdded = DateTime.Now,
                Message = "Message To Log",
                MessageFrom = "CWC.Gyro.Step.Detector"
            };

            // send message to log
            // we do not use async here as the main mehtods needs some work to do here to allow that.
            // we are teting here,  
            logginService.SendMessageToLog(loggingMessage);

            Console.WriteLine("Message writen to log");

            Console.ReadKey();
        }
    }
}
