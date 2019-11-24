using MyToolkits.Log.Console;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace SimJustFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleOutput output = new ConsoleOutput(MethodBase.GetCurrentMethod().Name);
            float[] data = new float[4];
            double value_x = 0.1;
            MyServer _server = new MyServer();
            _server.Listen();
            while (true)
            {
                data[0] = (float)Math.Sin(value_x);
                data[1] = (float)Math.Cos(value_x);
                data[2] = (float)(Math.Sin(value_x) / value_x);
                data[3] = (float)(Math.Sin(value_x) / value_x);
                List<byte> dataList = new List<byte>();
                foreach(float dat in data)
                {
                    dataList.AddRange(BitConverter.GetBytes(dat));
                }
                dataList.Add(0x00);
                dataList.Add(0x00);
                dataList.Add(0x80);
                dataList.Add(0x7f);
                _server.Send(dataList.ToArray());
                dataList.Clear();
                value_x += 0.01;
                Thread.Sleep(10);
            }
        }
    }
}
