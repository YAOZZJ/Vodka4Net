using System;

namespace SimFireWater
{
    class Program
    {
        static void Main(string[] args)
        {
            MyServer _server = new MyServer();
            _server.Listen();
            Console.WriteLine("服务器已启动,按回车键退出");
            Console.ReadLine();
        }
    }
}
