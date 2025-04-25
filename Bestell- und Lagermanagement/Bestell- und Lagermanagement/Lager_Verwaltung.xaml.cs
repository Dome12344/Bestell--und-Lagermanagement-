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
    /// Interaktionslogik für Lager_Verwaltung.xaml
    /// </summary>
    public partial class Lager_Verwaltung : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        public Lager_Verwaltung(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;

        }
        private void lagerinahlt_ansicht_Click(object sender, RoutedEventArgs e)
        {
            if (lagerinahlt_ansicht.IsEnabled == true)
            {
                Lagerinhalt_Ansicht lagerinhalt_Ansicht = new Lagerinhalt_Ansicht();
                lagerinhalt_Ansicht.Show();
            }
        }

        private void lager_bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (lager_bearbeiten.IsEnabled == true)
            {
                Lager_bearbeiten lager_Bearbeiten = new Lager_bearbeiten();
                lager_Bearbeiten.Show();
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

        private void lagerinhalt_hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            if (lagerinhalt_hinzufügen.IsEnabled == true)
            {
                Lagerinhalt_hinzufügen lagerinhalt_Hinzufügen = new Lagerinhalt_hinzufügen(new mitarbeiternummern(mitarbeiternummer));
                lagerinhalt_Hinzufügen.Show();
            }
        }
    }
}
