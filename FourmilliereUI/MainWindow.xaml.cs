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
using System.Collections.ObjectModel;


namespace FourmilliereUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SimulateurFourmi simulateur;
        private Fourmi reine;
        private Fourmi fourmi;
        //public ObservableCollection<Fourmi> fourmiList = new ObservableCollection<Fourmi>();
        //public List<Fourmi> fourmiList = new List<Fourmi>();
        private List<PersonnageAbstrait> fourmiList;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.fourmilliereVM;
            Dessine(0, 0, "Content/fourmiliere.jpg");
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            if (reine!=null)
            {
                fourmi = reine.Comportement.Cast<ComportementReine>().CreerFourmi();
                //fourmiList.Add(fourmi);
                fourmi.AttacherObs(simulateur);
                fourmiList = reine.Zone.LstPersonnages;
                fourmiList.Add(fourmi);
                Dessine(fourmi.Position.X+1, fourmi.Position.Y+1, "Content/fourmiRN.jpg");
            }
        }

        private void moins(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("non implémenté");
        }

        private Coordonnee GetMidPosition(ZoneAbstraite zone)
        {
            var posX = 1;
            var posY = 1;
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

        public void Dessine(int x, int y, string cheminImg)
        {
                /*
                Ellipse e = new Ellipse();
                e.Fill = new SolidColorBrush(Colors.Blue);
                e.Margin = new Thickness(3);
                */
                Image img = new Image();
                Uri uri = new Uri(cheminImg, UriKind.Relative);
                img.Source = new BitmapImage(uri);


                /*Plateau.Children.Add(e);
                Grid.SetColumn(e, uneFourmi.X);
                Grid.SetRow(e, uneFourmi.Y);
                */
                Terrain.Children.Add(img);
                Grid.SetColumn(img, x);
                Grid.SetRow(img, y);

        }

        private void Start(object sender, RoutedEventArgs e)
        {
            simulateur = SimulateurFourmi.GetInstance();
            var zone = simulateur.FabriqueZone.Creer();
            var midPos = GetMidPosition(zone);
            reine = simulateur.FabriqueFourmi.Creer(zone, midPos);
            reine.Comportement = new ComportementReine(reine);
            reine.AttacherObs(simulateur);
            RenderTerrain(Terrain, zone.LimitX, zone.LimitY);
            Dessine(zone.LimitX/zone.LimitX, zone.LimitY/ zone.LimitY, "Content/fourmiRN.jpg");
        }

        private void tour(object sender, RoutedEventArgs e)
        {
            if (fourmi != null)
            {
                Terrain.Children.Clear();
                Dessine(1, 1, "Content/fourmiRN.jpg");
                Dessine(2, 2, "Content/fourmiRN.jpg");
                Dessine(fourmi.Position.X++, fourmi.Position.Y++, "Content/fourmiRN.jpg");
            }
        }
    }
}
