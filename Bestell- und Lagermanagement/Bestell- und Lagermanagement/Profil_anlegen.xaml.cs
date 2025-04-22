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
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Bestell__und_Lagermanagement
{
    /// <summary>
    /// Interaktionslogik für Profil_anlegen.xaml
    /// </summary>
    public partial class Profil_anlegen : Window
    {
        public Profil_anlegen()
        {
            InitializeComponent();
        }

        private void zurück_Click(object sender, RoutedEventArgs e)
        {
            if(zurück.IsEnabled == true)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }

        private void profil_anlegen_Click(object sender, RoutedEventArgs e)
        {
            if (profil_anlegen.IsEnabled == true)
            {
                string verschluesselung = passwort.Password;
                string  hash = PasswordHasher.HashPassword(verschluesselung);
                string Mitarbeiternummer = "";
                if (mitarbeiternummer.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                        con.Open();
                        string pruefung_mitarbeiternummer = "SELECT Mitarbeiternummer FROM [dbo].[Mitarbeiterprofil] WHERE mitarbeiternummer=@Mitarbeiternummer";
                        SqlCommand cmd = new SqlCommand(pruefung_mitarbeiternummer, con);
                        cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Mitarbeiternummer = reader["mitarbeiternummer"].ToString();
                        }
                        reader.Close();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                    }
                    if(mitarbeiternummer.Text != Mitarbeiternummer)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                            con.Open();
                            string add_data = "INSERT INTO [dbo].[Mitarbeiterprofil] VALUES (@Mitarbeiternummer,@Benutzername, @Passwort,@Vorname,@Nachname,@E_Mail,@Telefon,@Diensthandy)";
                            SqlCommand cmd = new SqlCommand(add_data, con);
                            cmd.Parameters.AddWithValue("@Benutzername", benutzername.Text);
                            cmd.Parameters.AddWithValue("@Passwort", hash);
                            cmd.Parameters.AddWithValue("@Vorname", vorname.Text);
                            cmd.Parameters.AddWithValue("@Nachname", nachname.Text);
                            cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer.Text);
                            cmd.Parameters.AddWithValue("@E_Mail", mail.Text);
                            cmd.Parameters.AddWithValue("@Telefon", telefonnummer.Text);
                            cmd.Parameters.AddWithValue("@Diensthandy", diensthandynummer.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            benutzername.Text = "";
                            passwort.Password = "";
                            mitarbeiternummer.Text = "";
                            vorname.Text = "";
                            nachname.Text = "";
                            mail.Text = "";
                            telefonnummer.Text = "";
                            diensthandynummer.Text = "";

                        }
                        catch
                        {
                            MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte eine Mitarbeiternummer angeben die nicht Vergeben ist!");
                    }
                }


            }
        }
    }
}
