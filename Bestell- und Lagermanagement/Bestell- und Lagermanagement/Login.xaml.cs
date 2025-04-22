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
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
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

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (login.IsEnabled == true)
            {
                string verschluesselung = passwort.Password;
                string hash = PasswordHasher.HashPassword(verschluesselung);
                int nummere = Convert.ToInt32(mitarbeiternummer.Text);
                if (nummere <= 500)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                        con.Open();
                        string add_data = "SELECT * FROM [dbo].[Mitarbeiterprofil] where mitarbeiternummer = @Mitarbeiternummer and benutzername = @Benutzername and passwort = @Passwort";
                        SqlCommand cmd = new SqlCommand(add_data, con);
                        cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer.Text);
                        cmd.Parameters.AddWithValue("@Benutzername", benutzername.Text);
                        cmd.Parameters.AddWithValue("@Passwort", hash);
                        cmd.ExecuteNonQuery();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                        mitarbeiternummer.Text = "";
                        benutzername.Text = "";
                        passwort.Password = "";
                        if (count > 0)
                        {
                            Bestell__und_Lagermanagement_Auswahlbildschirm_Admin Auswahl_Admin = new Bestell__und_Lagermanagement_Auswahlbildschirm_Admin();
                            this.Close();
                            Auswahl_Admin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Passwort oder Username falsch");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Es besteht keine Verbindung zur SQL Server");
                    }

                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Server=DESKTOP\MYSQLSERVER;Database=BestellundLagermanagement;Integrated Security = True");
                        con.Open();
                        string add_data = "SELECT * FROM [dbo].[Mitarbeiterprofil] where mitarbeiternummer = @Mitarbeiternummer and benutzername = @Benutzername and passwort = @Passwort";
                        SqlCommand cmd = new SqlCommand(add_data, con);
                        cmd.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummer.Text);
                        cmd.Parameters.AddWithValue("@Benutzername", benutzername.Text);
                        cmd.Parameters.AddWithValue("@Passwort", hash);
                        cmd.ExecuteNonQuery();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                        mitarbeiternummer.Text = "";
                        benutzername.Text = "";
                        passwort.Password = "";
                        if (count > 0)
                        {
                            Bestell__und_Lagermanagement_Auswahlbildschirm Auswahl_Mitarbeiter = new Bestell__und_Lagermanagement_Auswahlbildschirm();
                            this.Close();
                            Auswahl_Mitarbeiter.Show();
                        }
                        else
                        {
                            MessageBox.Show("Passwort oder Username falsch");
                        }
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
