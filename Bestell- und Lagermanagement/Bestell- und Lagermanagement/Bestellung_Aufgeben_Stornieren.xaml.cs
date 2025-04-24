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
    /// Interaktionslogik für Bestellung_Aufgeben_Stornieren.xaml
    /// </summary>
    public partial class Bestellung_Aufgeben_Stornieren : Window
    {
        private mitarbeiternummern Mitarbeiternummern;
        public Bestellung_Aufgeben_Stornieren(mitarbeiternummern Mitarbeiternummern)
        {
            InitializeComponent();
            this.Mitarbeiternummern = Mitarbeiternummern;
        }

        private void stornieren_Click(object sender, RoutedEventArgs e)
        {
            if(stornieren.IsEnabled == true)
            {
                string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;

                string Bestellnummer = "";

                if (bestellnummer.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                        con.Open();
                        string pruefung_bestellnummer = "SELECT Bestellnummer FROM [dbo].[Bestellung] WHERE bestellnummer=@Bestellnummer";
                        SqlCommand cmd = new SqlCommand(pruefung_bestellnummer, con);
                        cmd.Parameters.AddWithValue("@Bestellnummer", bestellnummer.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Bestellnummer = reader["bestellnummer"].ToString();
                        }
                        reader.Close();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                    }
                    if (bestellnummer.Text == Bestellnummer)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                            con.Open();
                            string add_data = "DELETE FROM [dbo].[Bestellung]  WHERE Bestellnummer = @Bestellnummer";
                            SqlCommand cmd = new SqlCommand(add_data, con);
                            cmd.Parameters.AddWithValue("@Bestellnummer", bestellnummer.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            bestellnummer.Text = "";
                            bestellung_bezeichnung.Text = "";
                            anzahl.Text = "";
                            lieferantennummer.Text = "";
                            bestelldatum.Text = "";
                            lagerort.Text = "";
                            bestell_status.Text = "";


                        }
                        catch
                        {
                            MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte geben sie eine Bestellnummer ein die es gibt!");
                    }
                }
            }
        }

        private void hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            //DateTime dateTime = DateTime.Now;
            //string tag = dateTime.ToString("yyyy.MM.dd");
            if (hinzufügen.IsEnabled == true)
            {
                string mitarbeiternummer = Mitarbeiternummern.Mitarbeiternummern;

                string Bestellnummer = "";

                if (bestellnummer.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                        con.Open();
                        string pruefung_bestellnummer = "SELECT Bestellnummer FROM [dbo].[Bestellung] WHERE bestellnummer=@Bestellnummer";
                        SqlCommand cmd = new SqlCommand(pruefung_bestellnummer, con);
                        cmd.Parameters.AddWithValue("@Bestellnummer", bestellnummer.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Bestellnummer = reader["bestellnummer"].ToString();
                        }
                        reader.Close();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                    }
                    if (bestellnummer.Text != Bestellnummer)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                            con.Open();
                            string add_data = "INSERT INTO [dbo].[Bestellung] VALUES (@Bestellnummer,@BestellungBezeichung, @Anzahl,@Lieferantennummer,@Bestelldatum,@Lagerort,@BestellStatus,@Mitarbeiternummer)";
                            SqlCommand cmd = new SqlCommand(add_data, con);
                            cmd.Parameters.AddWithValue("@Bestellnummer", bestellnummer.Text);
                            cmd.Parameters.AddWithValue("@BestellungBezeichung", bestellung_bezeichnung.Text);
                            cmd.Parameters.AddWithValue("@Anzahl", anzahl.Text);
                            cmd.Parameters.AddWithValue("@Lieferantennummer", lieferantennummer.Text);
                            cmd.Parameters.AddWithValue("@Bestelldatum", bestelldatum.Text);
                            cmd.Parameters.AddWithValue("@Lagerort", lagerort.Text);
                            cmd.Parameters.AddWithValue("@BestellStatus", bestell_status.Text);
                            cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            bestellnummer.Text = "";
                            bestellung_bezeichnung.Text = "";
                            anzahl.Text = "";
                            lieferantennummer.Text = "";
                            bestelldatum.Text = "";
                            lagerort.Text = "";
                            bestell_status.Text = "";


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
