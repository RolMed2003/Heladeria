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
    /// Lógica de interacción para EditarProducto.xaml
    /// </summary>
    public partial class EditarProducto : Window
    {

        public EditarProducto()
        {

            InitializeComponent();

            nombreTxt.Text = Empleado.edit.Name;
            precioTxt.Text = Empleado.edit.Price.ToString();
            costoTxt.Text = Empleado.edit.Cost.ToString();
            cantidadTxt.Text = Empleado.edit.Amount.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using(SqlConnection cn = Connection.connect())
            {

                string price = precioTxt.Text;
                string cost = costoTxt.Text;
                string amount = cantidadTxt.Text;

                SqlCommand sqlCommand = new SqlCommand("update Products set Amount = '"+amount+"', Price = '"+price+"'," +
                    " Cost = '"+cost+"' where IDProduct = '"+ Empleado.edit.IDProduct +"'", cn);

                int x = sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Registro actualizado correctamente.", " -  Información.", MessageBoxButton.OK,
                    MessageBoxImage.Information);

                this.Close();



            }

        }
    }
}
