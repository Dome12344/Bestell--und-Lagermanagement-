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

namespace Bestell__und_Lagermanagement
{
    /// <summary>
    /// Interaktionslogik für Lager_bearbeiten.xaml
    /// </summary>
    public partial class Lager_bearbeiten : Window
    {
        private BestellundLagermanagementContext context = new BestellundLagermanagementContext();
        private ICollectionView collectionView;
        public Lager_bearbeiten()
        {
            InitializeComponent();
            context.Materiallager.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Materiallager.Local.ToObservableCollection());
            DataContext = collectionView;
        }

        private void bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            var ausgewähltesMaterial = (Materiallager)collectionView.CurrentItem;

            if (ausgewähltesMaterial != null)
            {
                ausgewähltesMaterial.Anzahl = int.Parse(anzahl.Text);
                ausgewähltesMaterial.Mindesbestand = int.Parse(mindes_bestand.Text);

                context.SaveChanges();

                
                if (ausgewähltesMaterial.Anzahl < ausgewähltesMaterial.Mindesbestand)
                {
                    MessageBox.Show("Warnung: Der Mindestbestand wurde unterschritten machen sie bitte eine Bestellung des Material!", "Lagerbestand", MessageBoxButton.OK);
                }
            }

        }

        private void zurück_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
