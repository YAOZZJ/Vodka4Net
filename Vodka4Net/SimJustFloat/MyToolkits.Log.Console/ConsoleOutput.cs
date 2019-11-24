using System;

namespace MyToolkits.Log.Console
{
    public class ConsoleOutput
    {
        public ConsoleOutput(string logger)
        {
            Logger = logger;
        }
        public void Write(string msg)
        {
            System.Console.Write(msg);
        }
        public void WriteLine(string msg ,bool ex = true)
        {
            if (ex || !string.IsNullOrEmpty(Logger)) System.Console.WriteLine($"{DateTime.Now.ToString(" HH:mm:ss fff")} | {Logger} | {msg}");
            else System.Console.WriteLine(msg);
        }
        public string Logger { get; set; }
    }
}
