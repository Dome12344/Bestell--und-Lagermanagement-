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
using static Bestell__und_Lagermanagement.Login;

namespace Bestell__und_Lagermanagement
{
    /// <summary>
    /// Interaktionslogik für Bestell__und_Lagermanagement_Auswahlbildschirm.xaml
    /// </summary>
    public partial class Bestell__und_Lagermanagement_Auswahlbildschirm : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        public Bestell__und_Lagermanagement_Auswahlbildschirm(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;
        }

        private void lieferanten_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            int nummer = Convert.ToInt32(mitarbeiternummer);
            if (nummer >= 100500)
            {
                if (lieferanten.IsEnabled == true)
                {
                    Lieferanten_Verwaltung lieferanten_Verwaltung = new Lieferanten_Verwaltung(new mitarbeiternummern(mitarbeiternummer));
                    this.Close();
                    lieferanten_Verwaltung.Show();
                }
            }
            else
            {
                MessageBox.Show("Sie sind kein Mitarbeiter dieser Abteilung");
            }
        }

        private void bestell_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            int nummer = Convert.ToInt32(mitarbeiternummer);
            if (nummer >= 100500)
            {
                if (bestell.IsEnabled == true)
                {
                    Bestellung_Verwaltung bestellung_Verwaltung = new Bestellung_Verwaltung(new mitarbeiternummern(mitarbeiternummer));
                    this. Close();
                    bestellung_Verwaltung.Show();
                }
            }
            else
            {
                MessageBox.Show("Sie sind kein Mitarbeiter dieser Abteilung");
            }
        }

        private void lager_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            int nummer = Convert.ToInt32(mitarbeiternummer);
            if (nummer > 500 && nummer < 100500)
            {
                if (lager.IsEnabled == true)
                {
                    Lager_Verwaltung lager_Verwaltung = new Lager_Verwaltung(new mitarbeiternummern(mitarbeiternummer));
                    this. Close();
                    lager_Verwaltung.Show();
                }
            }
            else
            {
                MessageBox.Show("Sie sind kein Mitarbeiter dieser Abteilung");
            }

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
