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
    /// Interaktionslogik für Passwort_aendern.xaml
    /// </summary>
    public partial class Passwort_aendern : Window
    {
        public Passwort_aendern()
        {
            InitializeComponent();
        }

        private void passwort_aendern_Click(object sender, RoutedEventArgs e)
        {
            if (passwort_aendern.IsEnabled == true)
            {
                string verschluesselung = neuespasswort.Password;
                string hash = PasswordHasher.HashPassword(verschluesselung);
                
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
                    if(mitarbeiternummer.Text == Mitarbeiternummer)
                    {
                        if (neuespasswort.Password == wiederholungneuespasswort.Password)
                        {
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("Update[dbo].[Mitarbeiterprofil] set Passwort = @Passwort Where mitarbeiternummer = @Mitarbeiternummer", con);
                                cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer.Text);
                                cmd.Parameters.AddWithValue("@Passwort", hash);




                                cmd.ExecuteNonQuery();
                                con.Close();
                                mitarbeiternummer.Text = "";
                                neuespasswort.Password = "";
                                wiederholungneuespasswort.Password = "";
                            }
                            catch
                            {
                                MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                            }

                        }
                    }
                }
            }
        }

        private void zurück_Click(object sender, RoutedEventArgs e)
        {
            if (zurück.IsEnabled == true)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }
    }
}
