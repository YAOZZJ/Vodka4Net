using GalaSoft.MvvmLight.Messaging;
using System;

namespace Vodka4Net.Service
{
    public class Message
    {
        static public void Write(string msg)
        {
            if (string.IsNullOrEmpty(msg)) return;
            Messenger.Default.Send<String>(DateTime.Now.ToString(" HH:mm:ss fff") + " | " + msg, "Message");
        }
        static public void WriteLine(string msg)
        {
            if (string.IsNullOrEmpty(msg)) return;
            Messenger.Default.Send<String>(DateTime.Now.ToString(" HH:mm:ss fff") + " | " + msg + "\r\n", "Message");
        }
    }
}
