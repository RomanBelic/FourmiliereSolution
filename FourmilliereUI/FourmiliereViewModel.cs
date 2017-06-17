using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using LibMetier;

namespace FourmilliereUI
{
    public class FourmiliereViewModel: ViewModelBase
    {
        private SimulateurFourmi simulateur;
        private Fourmi reine;

        public string titre;
        public string Titre
        {
            get { return titre; }
            set
            {
                titre = value;
                OnPropertyChanged("titre");
            }
        }
        public FourmiliereViewModel()
        {
            this.titre = "fourmilière";
            //simulateur = SimulateurFourmi.GetInstance();
            //var zone = simulateur.FabriqueZone.Creer();
            //var midPos = GetMidPosition(zone);
            //reine = simulateur.FabriqueFourmi.Creer(zone, midPos);
            //reine.Comportement = new ComportementReine(reine);
            //reine.AttacherObs(simulateur);
            //RenderTerrain(Terrain, zone.LimitX, zone.LimitY);

        }
        
    }
}
