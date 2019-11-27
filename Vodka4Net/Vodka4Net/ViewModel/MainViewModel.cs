using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace Vodka4Net.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ProtocolList = new ObservableCollection<string>()
            {
                "None","FireWater","JustFloat"
            };
            CommMethodList = new ObservableCollection<string>()
            {
                "TCPServer","TCPClient","UDP","Serial"
            };
            Ip = "127.0.0.1";
            Port = 9600;
            PortList = new ObservableCollection<int>() { 9600, 2333, 1234 };
            IpList = new ObservableCollection<string>() { "127.0.0.1", "192.168.250.1", "192.168.250.2", "192.168.250.10" };
        }
        #region Action
        void Action1() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action2() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action3() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action4() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action5() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action6() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void ActionDebug1() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void ActionDebug2() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void ActionDebug3() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void ActionDebug4() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void ActionDebug5() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void ActionDebug6() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        #endregion Action

        #region 私有成员
        string txtDebug1;
        string txtDebug2;
        string txtDebug3;

        int _port;
        string _ip;

        RelayCommand cmd1;
        RelayCommand cmd2;
        RelayCommand cmd3;
        RelayCommand cmd4;
        RelayCommand cmd5;
        RelayCommand cmd6;
        RelayCommand cmdDebug1;
        RelayCommand cmdDebug2;
        RelayCommand cmdDebug3;
        RelayCommand cmdDebug4;
        RelayCommand cmdDebug5;
        RelayCommand cmdDebug6;
        #endregion 私有成员
        #region 公共成员
        public ObservableCollection<string> ProtocolList { get; set; }
        public ObservableCollection<string> CommMethodList { get; set; }
        public ObservableCollection<int> PortList { get; set; }
        public ObservableCollection<string> IpList { get; set; }
        public int Port { get => _port; set => Set(ref _port, value); }
        public string Ip { get => _ip; set => Set(ref _ip, value); }
        public string TxtDebug1 { get => txtDebug1; set => Set(ref txtDebug1, value); }
        public string TxtDebug2 { get => txtDebug2; set => Set(ref txtDebug2, value); }
        public string TxtDebug3 { get => txtDebug3; set => Set(ref txtDebug3, value); }

        public RelayCommand BtnDebug1Command { get => cmdDebug1 ?? (cmdDebug1 = new RelayCommand(ActionDebug1)); }
        public RelayCommand BtnDebug2Command { get => cmdDebug2 ?? (cmdDebug2 = new RelayCommand(ActionDebug2)); }
        public RelayCommand BtnDebug3Command { get => cmdDebug3 ?? (cmdDebug3 = new RelayCommand(ActionDebug3)); }
        public RelayCommand BtnDebug4Command { get => cmdDebug4 ?? (cmdDebug4 = new RelayCommand(ActionDebug4)); }
        public RelayCommand BtnDebug5Command { get => cmdDebug5 ?? (cmdDebug5 = new RelayCommand(ActionDebug5)); }
        public RelayCommand BtnDebug6Command { get => cmdDebug6 ?? (cmdDebug6 = new RelayCommand(ActionDebug6)); }
        public RelayCommand Cmd1 { get => cmd1 ??(cmd1 = new RelayCommand(Action1));}
        public RelayCommand Cmd2 { get => cmd2 ??(cmd2 = new RelayCommand(Action2));}
        public RelayCommand Cmd3 { get => cmd3 ??(cmd3 = new RelayCommand(Action3));}
        public RelayCommand Cmd4 { get => cmd4 ??(cmd4 = new RelayCommand(Action4));}
        public RelayCommand Cmd5 { get => cmd5 ??(cmd5 = new RelayCommand(Action5));}
        public RelayCommand Cmd6 { get => cmd6 ??(cmd6 = new RelayCommand(Action6));}
        #endregion 公共成员
    }
}