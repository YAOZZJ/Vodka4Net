using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;

namespace Vodka4Net.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
            }
            MainTick = 0;
        }
        #region Action
        void Action1()
        {
            MainTick++;
            Debug.WriteLine(MainTick.ToString());
        }
        #endregion Action
        int _mainTick;
        #region ˽�г�Ա

        #endregion ˽�г�Ա
        RelayCommand cmd1;
        #region ������Ա
        public int MainTick { get => _mainTick; set => Set(ref _mainTick,value); }

        public RelayCommand Cmd1 { get => cmd1 ?? (cmd1 = new RelayCommand(Action1));  }
        #endregion ������Ա
    }
}