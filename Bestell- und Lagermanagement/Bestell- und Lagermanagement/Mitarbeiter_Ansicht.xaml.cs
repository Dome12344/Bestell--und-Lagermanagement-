using Bestell__und_Lagermanagement.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaktionslogik für Mitarbeiter_Ansicht.xaml
    /// </summary>
    public partial class Mitarbeiter_Ansicht : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        private BestellundLagermanagementContext context = new BestellundLagermanagementContext();
        private ICollectionView collectionView;
        public Mitarbeiter_Ansicht(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;
            context.Mitarbeiterprofil.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Mitarbeiterprofil.Local.ToObservableCollection());
            DataContext = collectionView;
        }

        private void neues_passwort_generieren_Click(object sender, RoutedEventArgs e)
        {
            string verschluesselung = neues_passwort.Text;
            string hash = PasswordHasher.HashPassword(verschluesselung);
            altes_passwort.Text = hash;
        }

        private void passwort_speichern_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void zurück_Click(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
            if (zurück.IsEnabled == true)
            {
                Bestell__und_Lagermanagement_Auswahlbildschirm_Admin bestell__Und_Lagermanagement_Auswahlbildschirm_Admin = new Bestell__und_Lagermanagement_Auswahlbildschirm_Admin(new mitarbeiternummern(mitarbeiternummer));
                this.Close();
                bestell__Und_Lagermanagement_Auswahlbildschirm_Admin.Show();
            }
        }
    }
}
