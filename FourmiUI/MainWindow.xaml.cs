using LibMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace FourmiUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Fourmi> lstFourmis = new List<Fourmi>();
        public MainWindow()
        {
            InitializeComponent();
            InitPlateau();
        }

        public void InitPlateau()
        {
            for (int i = 0; i < 20; i++)
            {
                Plateau.ColumnDefinitions.Add(new ColumnDefinition());
                Plateau.RowDefinitions.Add(new RowDefinition());
            }
            Ellipse ell = new Ellipse();
            ell.Margin = new Thickness(3);
            ell.Fill = new SolidColorBrush(Colors.Blue);
            Plateau.Children.Add(ell);
            Grid.SetColumn(ell, 4);
            Grid.SetColumn(ell, 5);
        }

        private void btnSuivant_Click(object sender, RoutedEventArgs e)
        {
            foreach(var f in lstFourmis)
            {

            }
        }

        private void btnEtapeSuivant_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(null);
        }
    }
}
