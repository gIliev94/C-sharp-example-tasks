using System;

namespace CarProduction.Loggers
{
    public class ConsoleApplicationLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
