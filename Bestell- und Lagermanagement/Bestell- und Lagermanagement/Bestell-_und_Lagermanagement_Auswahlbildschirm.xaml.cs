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
    /// Interaktionslogik für Bestell__und_Lagermanagement_Auswahlbildschirm.xaml
    /// </summary>
    public partial class Bestell__und_Lagermanagement_Auswahlbildschirm : Window
    {
        public Bestell__und_Lagermanagement_Auswahlbildschirm()
        {
            InitializeComponent();
        }

        private void lieferanten_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bestell_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lager_Click(object sender, RoutedEventArgs e)
        {

        }

        private void abmelden_Click(object sender, RoutedEventArgs e)
        {
            if (abmelden.IsEnabled = true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

        }
    }
}
