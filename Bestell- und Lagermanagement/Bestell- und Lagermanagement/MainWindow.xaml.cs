using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bestell__und_Lagermanagement
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

        private void profil_anlegen_Click(object sender, RoutedEventArgs e)
        {
            if (profil_anlegen.IsEnabled == true)
            {
                Profil_anlegen profil_Anlegen = new Profil_anlegen();
                this.Close();
                profil_Anlegen.Show();
            }
        }

        private void passwort_aendern_Click(object sender, RoutedEventArgs e)
        {
            if (passwort_aendern.IsEnabled == true)
            {
                Passwort_aendern passwort_Aendern = new Passwort_aendern();
                this.Close();
                passwort_Aendern.Show();
            }
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (login.IsEnabled == true)
            {
                Login Login = new Login();
                this.Close();
                Login.Show();
            }
        }
    }
}