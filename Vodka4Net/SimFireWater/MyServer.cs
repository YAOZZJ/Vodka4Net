using MyToolkits.Log.Console;
using MyToolkits.Sockets;
using System;
using System.Reflection;
using System.Text;

namespace SimFireWater
{
    public class MyServer
    {
        public MyServer()
        {
            Ip = "127.0.0.1";
            Port = 9600;
            output = new ConsoleOutput("MyServer");
        }

        #region Action
        void Start() { }
        void Stop() { }
        void Connect()
        {
            Listen(Port, Ip);
        }
        void Send()
        {
            if (string.IsNullOrEmpty(SendData) || !_server.IsListen || _server.GetConnectionCount() == 0) return;
            _server.Send(SendData, SelectedSession);
        }
        public void Listen(int port = 9600, string ip = "127.0.0.1")
        {
            Ip = ip;
            Port = port;
            _server = new SocketServer(Ip, Port);

            //处理从客户端收到的消息
            _server.HandleRecMsg = new Action<byte[], SocketConnection, SocketServer>((bytes, client, theServer) =>
            {
                string msg = Encoding.UTF8.GetString(bytes);
                output.WriteLine($"{client.RemoteEndPoint.ToString()}=>:{msg}");
            });

            //处理服务器启动后事件
            _server.HandleServerStarted = new Action<SocketServer>(theServer =>
            {
                output.WriteLine("服务已启动");
            });

            //处理新的客户端连接后的事件
            _server.HandleNewClientConnected = new Action<SocketServer, SocketConnection>((theServer, theCon) =>
            {
                output.WriteLine($@"一个新的客户端接入，当前连接数：{theServer.GetConnectionCount()}");
                //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.SystemIdle, new Action(() =>
                //{
                //    //ConnectionList.Add(theCon.RemoteEndPoint.ToString());
                //    ConnectionList.Clear();
                //    foreach (var node in _server.GetRemoteEndPointList())
                //    {
                //        ConnectionList.Add(node.ToString());
                //    }
                //}));
            });

            //处理客户端连接关闭后的事件
            _server.HandleClientClose = new Action<SocketConnection, SocketServer>((theCon, theServer) =>
            {
                output.WriteLine($@"一个客户端关闭，当前连接数为：{theServer.GetConnectionCount()}");
                //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.SystemIdle, new Action(() =>
                //{
                //    ConnectionList.Clear();
                //    if (_server.GetConnectionCount() < 1) return;
                //    foreach (var node in _server.GetRemoteEndPointList())
                //    {
                //        ConnectionList.Add(node.ToString());
                //    }
                //}));
            });

            //处理异常
            _server.HandleException = new Action<Exception>(ex =>
            {
                output.WriteLine(ex.Message);
            });

            //服务器启动
            _server.StartServer();
        }
        #endregion

        #region 私有成员
        SocketServer _server;

        int _port;
        string _ip;
        string _sendData;
        ConsoleOutput output;

        public int Port { get => _port; set => _port = value; }
        public string Ip { get => _ip; set => _ip = value; }
        public string SendData { get => _sendData; set => _sendData = value; }
        public string SelectedSession { get; set; }

        #endregion

        #region 公共成员

        #endregion
    }
}
