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

namespace CMDFrontend.Doctor.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void dDashboardExtend(object sender, MouseEventArgs e)
        {
            Maintab.Width = 150;
            homepage.Margin = new Thickness(150, 0, 0, 0);
        }

       

        private void dDashboardShrink(object sender, MouseEventArgs e)
        {
            Maintab.Width = 30;
            homepage.Margin = new Thickness(30, 0, 0, 0);
        }

        private void dLogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void dDashboardButton(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            Dmain_frame.Navigate(new Dashboard());
        }

        private void dPatientButton(object sender, RoutedEventArgs e)
        {
            Dmain_frame.Navigate(new Patient());
        }

        private void dSettingButton(object sender, RoutedEventArgs e)
        {
            Dmain_frame.Navigate(new AccountSetting());
        }
    }
}
