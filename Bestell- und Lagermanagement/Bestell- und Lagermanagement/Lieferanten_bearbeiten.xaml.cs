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
    /// Interaktionslogik für Lieferanten_bearbeiten.xaml
    /// </summary>
    public partial class Lieferanten_bearbeiten : Window
    {
        private BestellundLagermanagementContext context = new BestellundLagermanagementContext();
        private ICollectionView collectionView;
        public Lieferanten_bearbeiten()
        {
            InitializeComponent();
            context.Lieferanten.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Lieferanten.Local.ToObservableCollection());
            DataContext = collectionView;
        }

        private void bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (bearbeiten.IsEnabled = true)
            {
               context.SaveChanges();
            }
        }

        private void zurück_Click(object sender, RoutedEventArgs e)
        {
            if (zurück.IsEnabled = true)
            {
                this.Close();
            }
        }
    }
}
