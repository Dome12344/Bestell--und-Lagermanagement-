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

namespace Bestell__und_Lagermanagement
{
    /// <summary>
    /// Interaktionslogik für Passwort_aendern.xaml
    /// </summary>
    public partial class Passwort_aendern : Window
    {
        public Passwort_aendern()
        {
            InitializeComponent();
        }

        private void passwort_aendern_Click(object sender, RoutedEventArgs e)
        {
            if (passwort_aendern.IsEnabled == true)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }

        private void zurück_Click(object sender, RoutedEventArgs e)
        {
            if (zurück.IsEnabled == true)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }
    }
}
