using CovidApi;
using CovidApi.Models;
using MahApps.Metro.Controls;
using System.Windows;

namespace Covid19App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeApiClient();          
        }

        private async void Button_Pressed(object sender, RoutedEventArgs e)
        {
            DataModel data = await CovidSiteProcessor.LoadContextData(inputBox.Text);
            countryTxtBlck.Text = data.Country;
            confirmedTxtBlck.Text = data.Confirmed.ToString();
            recoveredTxtBlck.Text = data.Recovered.ToString();
            deathsTxtBlck.Text = data.Deaths.ToString();
        }
    }
}
