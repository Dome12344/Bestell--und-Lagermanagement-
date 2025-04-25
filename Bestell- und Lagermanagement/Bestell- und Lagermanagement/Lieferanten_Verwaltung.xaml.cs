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
    /// Interaktionslogik für Lieferanten_Verwaltung.xaml
    /// </summary>
    public partial class Lieferanten_Verwaltung : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        public Lieferanten_Verwaltung(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;
        }

        private void lieferanten_ansicht_Click(object sender, RoutedEventArgs e)
        {
            string mitrabeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            if(lieferanten_ansicht.IsEnabled == true)
            {
                Lieferanten_Ansicht lieferanten_Ansicht = new Lieferanten_Ansicht();
                lieferanten_Ansicht.Show();
            }
        }

        private void lieferanten_bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            string mitrabeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            if(lieferanten_bearbeiten.IsEnabled == true)
            {
                Lieferanten_bearbeiten lieferanten_Bearbeiten = new Lieferanten_bearbeiten();
                lieferanten_Bearbeiten.Show();
            }
        }

        private void lieferanten_hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            if(lieferanten_hinzufügen.IsEnabled == true)
            {
                Lieferanten_hinzufügen lieferanten_Hinzufügen = new Lieferanten_hinzufügen(new mitarbeiternummern(mitarbeiternummer));
                lieferanten_Hinzufügen.Show();
            }
        }



        private void zurück_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            int nummer = Convert.ToInt32(mitarbeiternummer);
            if (nummer <= 500)
            {
                if (zurück.IsEnabled == true)
                {
                    Bestell__und_Lagermanagement_Auswahlbildschirm_Admin bestell__Und_Lagermanagement_Auswahlbildschirm_Admin = new Bestell__und_Lagermanagement_Auswahlbildschirm_Admin(new mitarbeiternummern(mitarbeiternummer));
                    this.Close();
                    bestell__Und_Lagermanagement_Auswahlbildschirm_Admin.Show();
                }
            }
            else
            {
                if (zurück.IsEnabled == true)
                {
                    Bestell__und_Lagermanagement_Auswahlbildschirm bestell__Und_Lagermanagement_Auswahlbildschirm = new Bestell__und_Lagermanagement_Auswahlbildschirm(new mitarbeiternummern(mitarbeiternummer));
                    this.Close();
                    bestell__Und_Lagermanagement_Auswahlbildschirm.Show();
                }

            }
        }
    }
}
