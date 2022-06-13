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

namespace HeladeriaLosEspaciales1._0
{
    /// <summary>
    /// Lógica de interacción para Cliente.xaml
    /// </summary>
    public partial class Cliente : Window
    {

        public static string selection = "";

        public Cliente()
        {
            InitializeComponent();
        }

        private void salirBtn(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown(); 

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            selection = "Batido de piña";

            Ordenar ordenar = new Ordenar();
            ordenar.ShowDialog();

        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

            selection = "Batido de sandia";

            Ordenar ordenar = new Ordenar();
            ordenar.ShowDialog();

        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {

            selection = "Batido de fresa";

            Ordenar ordenar = new Ordenar();
            ordenar.ShowDialog();

        }
    }
}
