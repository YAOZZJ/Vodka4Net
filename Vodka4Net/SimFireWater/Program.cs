using MyToolkits.Log.Console;
using System;
using System.Reflection;
using System.Threading;

namespace SimFireWater
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleOutput output = new ConsoleOutput(MethodBase.GetCurrentMethod().Name);
            double[] data = new double[4];
            double value_x = 0.01;
            MyServer _server = new MyServer();
            _server.Listen();
            while (true)
            {
                data[0] = Math.Sin(value_x);
                data[1] = Math.Cos(value_x);
                data[2] = Math.Sin(value_x)/value_x;
                data[3] = Math.Sin(value_x)/value_x;
                value_x += 0.01;
                _server.Send($"d0:{string.Join(",", data)}\n");
                Thread.Sleep(10);
            }
            //output.WriteLine("服务器已启动,按回车键退出");
            //Console.ReadLine();
        }
    }
}
