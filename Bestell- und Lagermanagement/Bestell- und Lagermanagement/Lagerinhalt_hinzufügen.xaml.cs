using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
    /// Interaktionslogik für Lagerinhalt_hinzufügen.xaml
    /// </summary>
    public partial class Lagerinhalt_hinzufügen : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        public Lagerinhalt_hinzufügen(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;

        }

        private void hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            if (hinzufügen.IsEnabled == true)
            {
                string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;
                int Anzahl = Convert.ToInt32(anzahl.Text);
                int Mindebestand = Convert.ToInt32(mindesbestand.Text);
                string Lagernummern = "";
                if (lagernummer.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                        con.Open();
                        string pruefung_lieferantennummer = "SELECT Lagernummer FROM [dbo].[Materiallager] WHERE Lagernummer=@Lagernummer";
                        SqlCommand cmd = new SqlCommand(pruefung_lieferantennummer, con);
                        cmd.Parameters.AddWithValue("@Lagernummer", lagernummer.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Lagernummern = reader["Lagernummer"].ToString();
                        }
                        reader.Close();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                    }
                    if (lagernummer.Text != Lagernummern)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                            con.Open();
                            string add_data = "INSERT INTO [dbo].[Materiallager] Values (@Lagernummer,@MaterialWarenbezeichnung,@Laenge,@Breite,@Hoehe,@Anzahl,@Mindesbestand,@Lagerort,@Mitarbeiternummer)";

                            SqlCommand cmd = new SqlCommand(add_data, con);
                            cmd.Parameters.AddWithValue("@Lagernummer", lagernummer.Text);
                            cmd.Parameters.AddWithValue("@MaterialWarenbezeichnung", materialwarenbezeichnung.Text);
                            cmd.Parameters.AddWithValue("@Laenge", laenge.Text);
                            cmd.Parameters.AddWithValue("@Breite", breite.Text);
                            cmd.Parameters.AddWithValue("@Hoehe", hoehe.Text);
                            cmd.Parameters.AddWithValue("@Anzahl", Anzahl);
                            cmd.Parameters.AddWithValue("@Mindesbestand", Mindebestand);
                            cmd.Parameters.AddWithValue("@Lagerort", lagerort.Text);
                            cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            lagernummer.Text = "";
                            materialwarenbezeichnung.Text = "";
                            laenge.Text = "";
                            breite.Text = "";
                            hoehe.Text = "";
                            anzahl.Text = "";
                            mindesbestand.Text = "";
                            lagerort.Text = "";


                        }
                        catch
                        {
                            MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte eine Lagernummer angeben die nicht Vergeben ist!");
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
