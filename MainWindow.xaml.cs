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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_RadioButton
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void SemaforoEncendido_Checked(object sender, RoutedEventArgs e)
        {
            if (Verde.IsChecked == true)
            {
                LuzVerde.Opacity = 100;
            }
            else if (Rojo.IsChecked == true)
            {
                LuzRoja.Opacity = 100;
            }
            else if (Amarillo.IsChecked == true)
            {
                LuzAmarilla.Opacity = 100;
            }

        }
        private void SemaforoApagado_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Verde.IsChecked == false || Amarillo.IsChecked == false ||
                Rojo.IsChecked == false)
            {
                LuzVerde.Opacity = 0;
                LuzRoja.Opacity = 0;
                LuzAmarilla.Opacity = 0;
            }
        }
    }
}
