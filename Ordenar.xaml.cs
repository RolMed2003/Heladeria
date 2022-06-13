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
    /// Lógica de interacción para Ordenar.xaml
    /// </summary>
    public partial class Ordenar : Window
    {
        public Ordenar()
        {

            InitializeComponent();

            string sel = Cliente.selection;

            img_Copy.Visibility = Visibility.Hidden;
            img_Copy1.Visibility = Visibility.Hidden;
            img_Copy2.Visibility = Visibility.Hidden;
            img_Copy3.Visibility = Visibility.Hidden;
            img_Copy4.Visibility = Visibility.Hidden;
            img_Copy5.Visibility = Visibility.Hidden;
            img_Copy6.Visibility = Visibility.Hidden;
            img_Copy7.Visibility = Visibility.Hidden;
            img_Copy8.Visibility = Visibility.Hidden;

            if (sel.Equals("Batido de piña"))
            {

                img_Copy.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Batido de sandia"))
            {

                img_Copy1.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Batido de fresa"))
            {

                img_Copy2.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Canasta de helado"))
            {

                img_Copy3.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Cono junior"))
            {

                img_Copy4.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Cono triple"))
            {

                img_Copy5.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Copa de helado"))
            {

                img_Copy6.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Malteada de chocolate"))
            {

                img_Copy7.Visibility = Visibility.Visible;

            }
            else if (sel.Equals("Sundae"))
            {

                img_Copy8.Visibility = Visibility.Visible;

            }

            using (SqlConnection cn = Connection.connect())
            {

                SqlCommand sqlCommand = new SqlCommand("select Price, Amount from Products where Name = '"+ 
                    sel +"'", cn);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {

                    precioTxt.Text = sqlDataReader.GetDouble(0).ToString();
                    ordenMaxTxt.Text = sqlDataReader.GetInt32(1).ToString();

                }

                cn.Close();

            }

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {



        }

        private void Image_MouseLeftButtonDown1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown2(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown3(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown4(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown5(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown6(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown7(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown8(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
