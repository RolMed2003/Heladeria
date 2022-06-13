using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using HeladeriaLosEspaciales1._0.Clases;

namespace HeladeriaLosEspaciales1._0
{
    /// <summary>
    /// Lógica de interacción para VerPerfil.xaml
    /// </summary>
    public partial class VerPerfil : Window
    {
        public VerPerfil()
        {

            InitializeComponent();

            isaac.Visibility = Visibility.Hidden;
            jova.Visibility = Visibility.Hidden;
            estep.Visibility = Visibility.Hidden;

            using (SqlConnection cn = Connection.connect())
            {

                SqlCommand sqlCommand = new SqlCommand("select Name, Age, Line, DNI from Employ where Username = '"+ 
                    MainWindow.username +"'", cn);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {

                    nombreTxt.Text = sqlDataReader.GetString(0);
                    edadTxt.Text = sqlDataReader.GetInt32(1).ToString();
                    lineTxt.Text = sqlDataReader.GetString(2);
                    DNITxt.Text = sqlDataReader.GetString(3);
                    userTxt.Text = MainWindow.username;

                    if (MainWindow.username.Equals("Isaac"))
                    {

                        isaac.Visibility = Visibility.Visible;

                    }
                    else if (MainWindow.username.Equals("Jova"))
                    {

                        jova.Visibility = Visibility.Visible;

                    }
                    else if (MainWindow.username.Equals("Estephanie"))
                    {

                        estep.Visibility = Visibility.Visible;

                    }

                }

                cn.Close();

            }

        }
    }
}
