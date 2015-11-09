using System.IO;

namespace CarProduction.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            var messages = new string[1] { message };
            if(!Directory.Exists(@"D:\Logs"))
            {
                Directory.CreateDirectory(@"D:\Logs");
            }

            System.IO.File.WriteAllLines(@"D:\Logs\WriteLines", messages);
        }
    }
}
