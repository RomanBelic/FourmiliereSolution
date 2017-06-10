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

namespace FourmilliereUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.fourmilliereVM;
            Dessiner();
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("non implémenté");
        }

        private void moins(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("non implémenté");
        }

        public void InitTerrin()
        {
            Terrain.ColumnDefinitions.Clear();
            Terrain.RowDefinitions.Clear();
            Terrain.Children.Clear();

            for (int i = 0; i < App.fourmilliereVM.DimensionY; i++)
            {
                Terrain.ColumnDefinitions.Add(new ColumnDefinition());

            }
            for (int i = 0; i < App.fourmilliereVM.DimensionY; i++)
            {
                Terrain.RowDefinitions.Add(new RowDefinition());
            }
        }

        public void Dessiner()
        {
            InitTerrin();
        }

    }
}
