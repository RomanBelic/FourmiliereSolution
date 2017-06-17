using LibAbstraite;
using LibMetier;
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
        private SimulateurFourmi simulateur;
        private Fourmi reine;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.fourmilliereVM;
            simulateur = SimulateurFourmi.GetInstance();
            var zone = simulateur.FabriqueZone.Creer();
            var midPos = GetMidPosition(zone);
            reine = simulateur.FabriqueFourmi.Creer(zone, midPos);
            reine.Comportement = new ComportementReine(reine);
            reine.AttacherObs(simulateur);
            RenderTerrain(Terrain, zone.LimitX, zone.LimitY);
            Dessine();
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            var fourmi = reine.Comportement.Cast<ComportementReine>().CreerFourmi();
            fourmi.AttacherObs(simulateur);
            MessageBox.Show("fourmi créee " + fourmi.ToString());
            Dessine();
        }

        private void moins(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("non implémenté");
        }

        private Coordonnee GetMidPosition(ZoneAbstraite zone)
        {
            var posX = zone.LimitX / 2;
            var posY = zone.LimitY / 2;
            return new Coordonnee(posX, posY);
        }

        private void RenderTerrain(Grid gv, int limitX, int limitY)
        {
            Terrain.ColumnDefinitions.Clear();
            Terrain.RowDefinitions.Clear();
            Terrain.Children.Clear();

            for (int x = 0; x < limitX; x++)
            {
                gv.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int y = 0; y < limitY; y++)
            {
                gv.RowDefinitions.Add(new RowDefinition());
            }
        }

        public void Dessine()
        {
                /*
                Ellipse e = new Ellipse();
                e.Fill = new SolidColorBrush(Colors.Blue);
                e.Margin = new Thickness(3);
                */
                Image img = new Image();
                Uri uri = new Uri("Content/fourmiRN.jpg", UriKind.Relative);
                img.Source = new BitmapImage(uri);


                /*Plateau.Children.Add(e);
                Grid.SetColumn(e, uneFourmi.X);
                Grid.SetRow(e, uneFourmi.Y);
                */
                Terrain.Children.Add(img);
                Grid.SetColumn(img, reine.Position.X);
                Grid.SetRow(img, reine.Position.Y);

        }
    }
}
