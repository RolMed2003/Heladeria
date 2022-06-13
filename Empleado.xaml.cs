using HeladeriaLosEspaciales1._0.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HeladeriaLosEspaciales1._0
{
    /// <summary>
    /// Lógica de interacción para Empleado.xaml
    /// </summary>
    public partial class Empleado : Window
    {

        public class Producto
        {

            public int IDProduct { get; set; }
            public string Name { get; set; }
            public float Price { get; set; }
            public float Cost { get; set; }
            public int Amount { get; set; }

        }

        public static Producto edit = new Producto();

        public Empleado()
        {

            InitializeComponent();

            List<Producto> lista = new List<Producto>();

            using (SqlConnection cn = Connection.connect())
            {

                SqlCommand sqlCommand = new SqlCommand("select IDProduct, Name, Price, Cost, Amount from Products", cn);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    Producto producto = new Producto();

                    producto.IDProduct = sqlDataReader.GetInt32(0);
                    producto.Name = sqlDataReader.GetString(1);
                    producto.Price = (float)sqlDataReader.GetDouble(2);
                    producto.Cost = (float)sqlDataReader.GetDouble(3);
                    producto.Amount = sqlDataReader.GetInt32(4);

                    lista.Add(producto);

                }

                cn.Close();

                for (int i = 0; i < lista.Count; i++)
                {

                    productsTbl.Items.Add(lista[i]);

                }

            }

        }

        private void salirBtn(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();

        }

        private void agregarproductoBtn_Click(object sender, RoutedEventArgs e)
        {

            int selected = productsTbl.SelectedIndex;

            if(selected == -1)
            {

                MessageBox.Show("Por favor, seleccione un producto de la lista.", " -  Advertencia",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
             
                edit = (Producto) productsTbl.Items.GetItemAt(selected);

                EditarProducto agregarProducto = new EditarProducto();
                agregarProducto.Owner = this;
                agregarProducto.ShowDialog();

            }

        }

        private void Window_Activated(object sender, EventArgs e) {}

        private void Window_Loaded(object sender, RoutedEventArgs e) {}

        private void productsTbl_MouseEnter(object sender, MouseEventArgs e){}

        private void productsTbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {}

        private void productsTbl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            img.Visibility = Visibility.Hidden;
            img_Copy.Visibility = Visibility.Hidden;
            img_Copy1.Visibility = Visibility.Hidden;
            img_Copy2.Visibility = Visibility.Hidden;
            img_Copy3.Visibility = Visibility.Hidden;
            img_Copy4.Visibility = Visibility.Hidden;
            img_Copy5.Visibility = Visibility.Hidden;
            img_Copy6.Visibility = Visibility.Hidden;
            img_Copy7.Visibility = Visibility.Hidden;

            int selected = productsTbl.SelectedIndex;

            if (selected != -1)
            {

                Producto producto = (Producto)productsTbl.Items.GetItemAt(selected);

                string foto = producto.Name;

                if (foto.Equals("Batido de fresa"))
                {

                    img_Copy1.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Batido de piña"))
                {

                    img.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Batido de sandia"))
                {

                    img_Copy.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Canasta de helado"))
                {

                    img_Copy2.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Cono junior"))
                {

                    img_Copy3.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Cono triple"))
                {

                    img_Copy4.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Copa de helado"))
                {

                    img_Copy5.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Malteada de chocolate"))
                {

                    img_Copy6.Visibility = Visibility.Visible;

                }
                else if (foto.Equals("Sundae"))
                {

                    img_Copy7.Visibility = Visibility.Visible;

                }

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            productsTbl.Items.Clear();

            List<Producto> lista = new List<Producto>();

            using (SqlConnection cn = Connection.connect())
            {

                SqlCommand sqlCommand = new SqlCommand("select IDProduct, Name, Price, Cost, Amount from Products", cn);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    Producto producto = new Producto();

                    producto.IDProduct = sqlDataReader.GetInt32(0);
                    producto.Name = sqlDataReader.GetString(1);
                    producto.Price = (float)sqlDataReader.GetDouble(2);
                    producto.Cost = (float)sqlDataReader.GetDouble(3);
                    producto.Amount = sqlDataReader.GetInt32(4);

                    lista.Add(producto);

                }

                cn.Close();

                for (int i = 0; i < lista.Count; i++)
                {

                    productsTbl.Items.Add(lista[i]);

                }

            }

        }

        private void cerrarsesionBtn(object sender, RoutedEventArgs e)
        {

            this.Close();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void eliminarproductoBtn_Click(object sender, RoutedEventArgs e)
        {

            int selected = productsTbl.SelectedIndex;

            if(selected != -1)
            {

                Producto delete = (Producto)productsTbl.Items.GetItemAt(selected);

                int IDProduct = delete.IDProduct;

                using (SqlConnection cn = Connection.connect())
                {

                    SqlCommand sqlCommand = new SqlCommand("delete from Products where IDProduct = '"+ IDProduct +"'", cn);

                    int x = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Registro eliminado exitosamente.", " -  Información.", MessageBoxButton.OK,
                        MessageBoxImage.Information);

                    cn.Close();

                }

            }
            else
            {

                MessageBox.Show("Por favor, seleccione un producto de la lista.", " -  Advertencia",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }

        }

        private void verPerfilBtn_Click(object sender, RoutedEventArgs e)
        {

            VerPerfil verPerfil = new VerPerfil();
            verPerfil.ShowDialog();

        }
    }
}
