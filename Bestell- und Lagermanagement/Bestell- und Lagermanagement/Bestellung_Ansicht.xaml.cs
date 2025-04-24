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
    /// Interaktionslogik für Bestellung_Ansicht.xaml
    /// </summary>
    public partial class Bestellung_Ansicht : Window
    {
        private BestellundLagermanagementContext context = new BestellundLagermanagementContext();
        private ICollectionView collectionView;
        public Bestellung_Ansicht()
        {
            InitializeComponent();
            context.Bestellung.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Bestellung.Local.ToObservableCollection());
            DataContext = collectionView;
        }

        private void suche_Click(object sender, RoutedEventArgs e)
        {
            string searchStr1 = bestellnummer.Text.ToLower();
            string searchStr2 = lieferantenummer.Text.ToLower();
            string searchStr3 = lagerort.Text.ToLower();


            var view = CollectionViewSource.GetDefaultView(bestellungGrid.ItemsSource);

            if (view == null) return;


            view.Filter = item =>
            {
                var bestellung = item as Bestellung;
                if (bestellung == null) return false;


                bool match1 = string.IsNullOrWhiteSpace(searchStr1) || bestellung.Bestellnummer.ToString().Contains(searchStr1);
                bool match2 = string.IsNullOrWhiteSpace(searchStr2) || (bestellung.Lieferantennummer.ToString() != null && bestellung.Lieferantennummer.ToString().ToLower().Contains(searchStr2));
                bool match3 = string.IsNullOrWhiteSpace(searchStr3) || (bestellung.Lagerort != null && bestellung.Lagerort.ToLower().Contains(searchStr3));


                return match1 && match2 && match3;
            };


            view.Refresh();
        }

        private void zurück_Click(object sender, RoutedEventArgs e)
        {
            if(zurück.IsEnabled == true)
            {
                this.Close();
            }
        }
    }
}
