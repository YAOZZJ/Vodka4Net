using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vodka4Net.View
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            Messenger.Default.Register<String>(this, "Message", message=>
            {
                Application.Current.Dispatcher.BeginInvoke(new Action(()=> { TxtMessage.AppendText(message); }));
                //TxtMessage.AppendText(message);
            });
        }

        private void TxtMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtMessage.ScrollToEnd();
        }
    }
}
