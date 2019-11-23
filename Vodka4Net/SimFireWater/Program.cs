using MyToolkits.Log.Console;
using System;
using System.Reflection;

namespace SimFireWater
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleOutput output = new ConsoleOutput(MethodBase.GetCurrentMethod().Name);
            MyServer _server = new MyServer();
            _server.Listen();
            output.WriteLine("服务器已启动,按回车键退出");
            Console.ReadLine();
        }
    }
}
