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
    /// Interaktionslogik für Lagerinhalt_Ansicht.xaml
    /// </summary>
    public partial class Lagerinhalt_Ansicht : Window
    {
        private BestellundLagermanagementContext context = new BestellundLagermanagementContext();
        private ICollectionView collectionView;
        public Lagerinhalt_Ansicht()
        {
            InitializeComponent();
            context.Materiallager.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Materiallager.Local.ToObservableCollection());
            DataContext = collectionView;

        }

        private void suche_Click(object sender, RoutedEventArgs e)
        {
            string searchStr1 = lagernummer.Text.ToLower();
            string searchStr2 = material_waren_bezeichnung.Text.ToLower();
            string searchStr3 = lagerort.Text.ToLower();


            var view = CollectionViewSource.GetDefaultView(LagerGrid.ItemsSource);

            if (view == null) return;


            view.Filter = item =>
            {
                var lager = item as Materiallager;
                if (lager == null) return false;


                bool match1 = string.IsNullOrWhiteSpace(searchStr1) || lager.Lagernummer.ToString().Contains(searchStr1);
                bool match2 = string.IsNullOrWhiteSpace(searchStr2) || (lager.MaterialWarenbezeichnung.ToString() != null && lager.MaterialWarenbezeichnung.ToString().ToLower().Contains(searchStr2));
                bool match3 = string.IsNullOrWhiteSpace(searchStr3) || (lager.Lagerort != null && lager.Lagerort.ToLower().Contains(searchStr3));


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
