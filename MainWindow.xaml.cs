using HeladeriaLosEspaciales1._0.Clases;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeladeriaLosEspaciales1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string username = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void salirBtn(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();

        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {

            username = usernameTxt.Text;
            string password = passwordTxt.Password.ToString();

            using (SqlConnection cn = Connection.connect())
            {

                SqlCommand sqlCommand = new SqlCommand("select IDUser, Access from Users where Username = '" +
                    username + "' and Password = '" + password + "'", cn);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {

                    string access = sqlDataReader.GetString(1);

                    if (access.Equals("Cliente"))
                    {

                        this.Hide();

                        Cliente cliente = new Cliente();
                        cliente.Owner = this;
                        cliente.Show();

                        MessageBox.Show("Bienvenido " + username + ".\nHas iniciado sesión como " + access + ".", "Bienvenida.",
                            MessageBoxButton.OK, MessageBoxImage.Information);

                        cn.Close();

                    }
                    else
                    {

                        this.Hide();

                        Empleado empleado = new Empleado();
                        empleado.Owner = this;
                        empleado.Show();

                        MessageBox.Show("Bienvenido " + username + ".\nHas iniciado sesión como " + access + ".", "Bienvenida.",
                            MessageBoxButton.OK, MessageBoxImage.Information);

                        cn.Close();

                    }
                                        
                }
                else
                {

                    MessageBox.Show("Datos de acceso incorrectos.", "Error al iniciar sesión.", MessageBoxButton.OK,
                        MessageBoxImage.Warning);

                }

            }

        }
    }
}
