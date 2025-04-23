using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaktionslogik für Lieferanten_hinzufügen.xaml
    /// </summary>
    public partial class Lieferanten_hinzufügen : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        public Lieferanten_hinzufügen(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;
        }

        private void hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            if (hinzufügen.IsEnabled == true)
            {
                string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
                decimal preis = Convert.ToDecimal(Preis.Text); 
                string Lieferantennummer = "";
                if (lieferantennummer.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                        con.Open();
                        string pruefung_lieferantennummer = "SELECT Lieferantennummer FROM [dbo].[Lieferanten] WHERE lieferantennummer=@Lieferantennummer";
                        SqlCommand cmd = new SqlCommand(pruefung_lieferantennummer, con);
                        cmd.Parameters.AddWithValue("@Lieferantennummer", lieferantennummer.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Lieferantennummer = reader["lieferantennummer"].ToString();
                        }
                        reader.Close();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                    }
                    if (lieferantennummer.Text != Lieferantennummer)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                            con.Open();
                            string add_data = "INSERT INTO [dbo].[Lieferanten] VALUES (@Lieferantennummer,@FrimenName, @FirmenSitze,@Preis,@Lieferzeit,@WelcheWarensindverfuegbar,@Mitarbeiternummer)";
                            SqlCommand cmd = new SqlCommand(add_data, con);
                            cmd.Parameters.AddWithValue("@Lieferantennummer", lieferantennummer.Text);
                            cmd.Parameters.AddWithValue("@FrimenName", firmen_name.Text);
                            cmd.Parameters.AddWithValue("@FirmenSitze", firmen_sitz.Text);
                            cmd.Parameters.AddWithValue("@Preis", preis);
                            cmd.Parameters.AddWithValue("@Lieferzeit", lieferzeit.Text);
                            cmd.Parameters.AddWithValue("@WelcheWarensindverfuegbar", welche_waren_sind_verfügbar.Text);
                            cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            lieferantennummer.Text = "";
                            firmen_name.Text = "";
                            firmen_sitz.Text = "";
                            Preis.Text = "";
                            lieferzeit.Text = "";
                            welche_waren_sind_verfügbar.Text = "";
                            

                        }
                        catch
                        {
                            MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte eine Lieferantennummer angeben die nicht Vergeben ist!");
                    }
                }
            }
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
