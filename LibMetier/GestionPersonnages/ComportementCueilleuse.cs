using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using LibMetier.GestionObjets;

namespace LibMetier
{
   public class ComportementCueilleuse : ComportementFourmi
   {
        private int incrementIdPheromone = 0;
        List<ObjetAbstrait> objetsTrouvés = new List<ObjetAbstrait>();

        public ComportementCueilleuse(Fourmi fourmi) : base(fourmi)
        {

        }

        public override void Creuser(ZoneAbstraite uneZone)
        {
            //base.Creuser();
        
            if (ContientObjet(uneZone))
            {
                PrendreObjet(uneZone);
            }

        }

        public override void PrendreObjet(ZoneAbstraite uneZone)
        {
           foreach(ObjetAbstrait o in fourmi.LstObjets) {
                //heritage


           }

            //base.PrendreObjet(objet);
            foreach (ObjetAbstrait unObjet in uneZone.ListObjets)
            {
                if(unObjet.GetType().Name != "Pheromone")
                {
                    objetsTrouvés.Add(unObjet);             // Ajout d'un objet dans la liste cueilleuse
                    DeposerPheromone(uneZone);              // Notify toutes les fourmis après dépot de phéromone... ?
                    uneZone.ListObjets.Remove(unObjet);     // Envlève un objet dans la liste d'objets de la zone
                }
                
            }
        }

        public override void DeposerPheromone(ZoneAbstraite uneZone)
        {
            //return base.DeposerPheromone();
            Console.WriteLine("Dépôt d'un Phéromone dans la zone... "+uneZone.Nom);

            uneZone.ListObjets.Add(new Pheromone(incrementIdPheromone++, "Phéromone"));
        }

        public override bool ContientObjet(ZoneAbstraite uneZone)
        {
            //return base.ChercherObjet(uneZone);
            Console.WriteLine("Rechercher un objet...");

            if (uneZone.ListObjets.Count != 0)
            {
                Console.WriteLine("Au moins un objet trouvé dans cette zone... "+uneZone.Nom);
                return true;
            }
            Console.WriteLine("Pas d'objet trouvé dans cette zone... "+uneZone.Nom);
            return false;
        }
    }
}
