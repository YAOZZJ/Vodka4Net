using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;
using System.Reflection;

namespace Vodka4Net.ViewModel
{
    public class DebugViewModel : ViewModelBase
    {
        public DebugViewModel()
        {

        }
        #region Action
        void Action1() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action2() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action3() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action4() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action5() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        void Action6() { Debug.WriteLine(MethodBase.GetCurrentMethod().Name); }
        #endregion Action
        #region 私有成员

        #endregion 私有成员
        string txtDebug1;
        string txtDebug2;
        string txtDebug3;

        RelayCommand cmd1;
        RelayCommand cmd2;
        RelayCommand cmd3;
        RelayCommand cmd4;
        RelayCommand cmd5;
        RelayCommand cmd6;
        #region 公共成员

        public string TxtDebug1 { get => txtDebug1; set => Set(ref txtDebug1,value); }
        public string TxtDebug2 { get => txtDebug2; set => Set(ref txtDebug2, value); }
        public string TxtDebug3 { get => txtDebug3; set => Set(ref txtDebug3, value); }

        public RelayCommand BtnDebug1Command { get => cmd1 ?? (cmd1 = new RelayCommand(Action1)); }
        public RelayCommand BtnDebug2Command { get => cmd2 ?? (cmd2 = new RelayCommand(Action2)); }
        public RelayCommand BtnDebug3Command { get => cmd3 ?? (cmd3 = new RelayCommand(Action3)); }
        public RelayCommand BtnDebug4Command { get => cmd4 ?? (cmd4 = new RelayCommand(Action4)); }
        public RelayCommand BtnDebug5Command { get => cmd5 ?? (cmd5 = new RelayCommand(Action5)); }
        public RelayCommand BtnDebug6Command { get => cmd6 ?? (cmd6 = new RelayCommand(Action6)); }
        
        #endregion 公共成员
    }
}
