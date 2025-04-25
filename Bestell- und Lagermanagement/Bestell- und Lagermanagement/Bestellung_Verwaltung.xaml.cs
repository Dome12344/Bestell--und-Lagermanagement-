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
    /// Interaktionslogik für Bestellung_Verwaltung.xaml
    /// </summary>
    public partial class Bestellung_Verwaltung : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        public Bestellung_Verwaltung(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;
        }

        private void bestellung_ansicht_Click(object sender, RoutedEventArgs e)
        {
            if(bestellung_ansicht.IsEnabled == true)
            {
                Bestellung_Ansicht bestellung_Ansicht = new Bestellung_Ansicht();
                bestellung_Ansicht.Show();
            }
        }

        private void bestellung_bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (bestellung_bearbeiten.IsEnabled == true)
            {
                Bestellung_bearbeiten bestellung_Bearbeiten = new Bestellung_bearbeiten();
                bestellung_Bearbeiten.Show();
            }
        }

        private void bestellung_aufgeben_stornieren_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            if (bestellung_aufgeben_stornieren.IsEnabled == true)
            {
                Bestellung_Aufgeben_Stornieren bestellung_Aufgeben_Stornieren = new Bestellung_Aufgeben_Stornieren(new mitarbeiternummern(mitarbeiternummer));
                bestellung_Aufgeben_Stornieren.Show();
            }
        }

        private void abmelden_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            int nummer = Convert.ToInt32(mitarbeiternummer);
            if (nummer <= 500)
            {
                if (abmelden.IsEnabled == true)
                {
                    Bestell__und_Lagermanagement_Auswahlbildschirm_Admin bestell__Und_Lagermanagement_Auswahlbildschirm_Admin = new Bestell__und_Lagermanagement_Auswahlbildschirm_Admin(new mitarbeiternummern(mitarbeiternummer));
                    this.Close();
                    bestell__Und_Lagermanagement_Auswahlbildschirm_Admin.Show();
                }
            }
            else
            {
                if (abmelden.IsEnabled == true)
                {
                    Bestell__und_Lagermanagement_Auswahlbildschirm bestell__Und_Lagermanagement_Auswahlbildschirm = new Bestell__und_Lagermanagement_Auswahlbildschirm(new mitarbeiternummern(mitarbeiternummer));
                    this.Close();
                    bestell__Und_Lagermanagement_Auswahlbildschirm.Show();
                }

            }
        }
    }
}
