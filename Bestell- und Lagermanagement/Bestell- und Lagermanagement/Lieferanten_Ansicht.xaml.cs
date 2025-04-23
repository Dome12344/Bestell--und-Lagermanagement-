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
    /// Interaktionslogik für Lieferanten_Ansicht.xaml
    /// </summary>
    public partial class Lieferanten_Ansicht : Window
    {
        private BestellundLagermanagementContext context = new BestellundLagermanagementContext();
        private ICollectionView collectionView;
        public Lieferanten_Ansicht()
        {
            InitializeComponent();
            context.Lieferanten.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Lieferanten.Local.ToObservableCollection());
            DataContext = collectionView;
        }

        private void suche_Click(object sender, RoutedEventArgs e)
        {
            
            string searchStr1 = lieferantennummer.Text.ToLower();
            string searchStr2 = firmen_name.Text.ToLower();
            string searchStr3 = welche_waren_sind_verfügbar.Text.ToLower();

            // CollectionView abrufen
            var view = CollectionViewSource.GetDefaultView(lieferantenGrid.ItemsSource);

            if (view == null) return; 

            
            view.Filter = item =>
            {
                var lieferant = item as Lieferanten;
                if (lieferant == null) return false;

                
                bool match1 = string.IsNullOrWhiteSpace(searchStr1) || lieferant.Lieferantennummer.ToString().Contains(searchStr1);
                bool match2 = string.IsNullOrWhiteSpace(searchStr2) || (lieferant.FrimenName != null && lieferant.FrimenName.ToLower().Contains(searchStr2));
                bool match3 = string.IsNullOrWhiteSpace(searchStr3) || (lieferant.WelcheWarensindverfuegbar != null && lieferant.WelcheWarensindverfuegbar.ToLower().Contains(searchStr3));

                
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
