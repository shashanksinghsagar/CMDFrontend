using CMDFrontend.Doctor.View;
using CMDFrontend.Patient.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMDFrontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoctorLogIn(object sender, RoutedEventArgs e)
        {
            Doctor.View.HomePage dhomePage = new Doctor.View.HomePage();
            dhomePage.Show();
            this.Close();
        }

        private void PatientLogIn(object sender, RoutedEventArgs e)
        {
            Patient.View.HomePage phomePage = new Patient.View.HomePage();
            phomePage.Show();
            this.Close();
        }

       

        private void pSignInButton(object sender, RoutedEventArgs e)
        {
            PatientSignUpForm patientSignUpForm = new PatientSignUpForm();
            patientSignUpForm.ShowDialog();
        }

        private void dSignInButton(object sender, RoutedEventArgs e)
        {
            DocSignUp docSignUp = new DocSignUp();
            docSignUp.ShowDialog();
        }
    }
}
