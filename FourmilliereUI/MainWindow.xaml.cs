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
            simulateur = SimulateurFourmi.GetInstance();
            var zone = simulateur.FabriqueZone.Creer();
            var midPos = GetMidPostion(zone);
            reine = simulateur.FabriqueFourmi.Creer(zone, midPos);
            reine.Comportement = new ComportementReine(reine);
            RenderTerrain(Terrain, zone.LimitX, zone.LimitY);
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("non implémenté");
        }

        private void moins(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("non implémenté");
        }

        private Coordonnee GetMidPostion(ZoneAbstraite zone)
        {
            var posX = zone.LimitX / 2;
            var posY = zone.LimitY / 2;
            return new Coordonnee(posX, posY);
        }

        private void RenderTerrain(Grid gv, int limitX, int limitY)
        {
            for (int x = 0; x < limitX; x++)
            {
                gv.ColumnDefinitions.Add(new ColumnDefinition() { });
            }
            for (int y = 0; y < limitY; y++)
            {
                gv.RowDefinitions.Add(new RowDefinition());
            }
        }
    }
}
