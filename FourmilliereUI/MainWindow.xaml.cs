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
        static Random hazard = new Random();
        public List<Fourmi> fourmiList = new List<Fourmi>();
        public List<Nourriture> listNourriture = new List<Nourriture>();
        public Nourriture nourriture;

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
                fourmi.AttacherObs(simulateur);
                fourmiList.Add(fourmi);
                //if (fourmi.Etat == Oeuf)
                //{
                    Dessine(fourmi.Position.X + 1, fourmi.Position.Y + 1, "Content/oeuf.jpg");
                //}
                //Dessine(fourmi.Position.X+1, fourmi.Position.Y+1, "Content/fourmiRN.jpg");
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
                Image img = new Image();
                Uri uri = new Uri(cheminImg, UriKind.Relative);
                img.Source = new BitmapImage(uri);

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
        
            Dessine(zone.LimitX / 2, zone.LimitY / 2, "Content/fourmiRNRN.jpg");
        
        }

        private void tour(object sender, RoutedEventArgs e)
        {
            if (fourmi != null)
            {
                    Avancer1Tour(20, 20);
            }
        }
        public void Avancer1Tour(int dimX, int dimY)
        {
            AvanceAuHazrard(dimX, dimY);

        }
        private void AvanceAuHazrard(int dimX, int dimY)
        {
            RenderTerrain(Terrain, 20, 20);
            foreach (var uneFourmi in fourmiList)
            {
                uneFourmi.tourFourmi++;
                if (uneFourmi.tourFourmi < 5)
                {
                    Dessine(fourmi.Position.X + 1, fourmi.Position.Y + 1, "Content/oeuf.jpg");
                    Dessine(20 / 2, 20 / 2, "Content/fourmiRNRN.jpg");
                }
                else
                {
                    int newX = uneFourmi.Position.X + hazard.Next(3) - 1;
                    int newY = uneFourmi.Position.Y + hazard.Next(3) - 1;

                    if ((newX >= 0) && (newX < dimX)) uneFourmi.Position.X = newX;
                    if ((newY >= 0) && (newY < dimY)) uneFourmi.Position.Y = newY;
                    Dessine(20 / 2, 20 / 2, "Content/fourmiRNRN.jpg");
                    Dessine(uneFourmi.Position.X, uneFourmi.Position.Y, "Content/fourmiRN.jpg");
                }
            }
            foreach (var item in listNourriture)
            {
                Dessine(nourriture.nourrX, nourriture.nourrY, "Content/nourriture.jpg");
            }
        }

        private void go(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                Avancer1Tour(20, 20);
                
            }
        }

        private void AjoutNourriture(object sender, RoutedEventArgs e)
        {
            nourriture = new Nourriture(1, 1);
            listNourriture.Add(nourriture);
            Dessine(nourriture.nourrX, nourriture.nourrY, "Content/nourriture.jpg");
        }
    }
}
