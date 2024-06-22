using hygge_imaotai.Domain;
using Newtonsoft.Json;
using System.Windows;

namespace hygge_imaotai.UserInterface.UserControls {
    /// <summary>
    /// SystemConfigControl.xaml 的交互逻辑
    /// </summary>
    public partial class SystemConfigControl {
        public SystemConfigControl() {
            InitializeComponent();
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            App.Config.AutoStart = cbxAutoStart.IsChecked.Value;
            App.Config.AutoBuy = cbxAutoBuy.IsChecked.Value;
            App.Config.BuyStartHour = tbxBuyStartHour.Text;
            App.Config.BuyStartMinute = tbxBuyStartMinuter.Text;
            App.Config.BuyStartSecond = tbxBuyStartSecond.Text;

            new SystemRun().SetAutoStart(App.Config.AutoStart);

            App.WriteCache("config.json", JsonConvert.SerializeObject(App.Config));
        }

        private void SystemConfigControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            cbxAutoStart.IsChecked = App.Config.AutoStart;
            cbxAutoBuy.IsChecked = App.Config.AutoBuy;
            tbxBuyStartHour.Text = App.Config.BuyStartHour;
            tbxBuyStartMinuter.Text = App.Config.BuyStartMinute;
            tbxBuyStartSecond.Text = App.Config.BuyStartSecond;
        }
    }
}
