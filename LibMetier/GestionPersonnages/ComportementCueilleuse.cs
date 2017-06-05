using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
   public class ComportementCueilleuse : ComportementFourmi
   {
        private FabriquePheromone fabrique = FabriquePheromone.GetInstance();

        public ComportementCueilleuse(Fourmi fourmi) : base(fourmi)
        {
        }

        public override void Creuser(ZoneAbstraite uneZone)
        {
        }

        public override void RechercherObjet(ZoneAbstraite uneZone)
        {
            if (uneZone.LstObjets.Count > 0)
            {
                for(int x = fourmi.Position.X; x <= uneZone.LimitX; x++)
                {
                    for(int y = fourmi.Position.Y; y <= uneZone.LimitY; y++)
                    {
                        foreach(ObjetAbstrait unObjet in uneZone.LstObjets)
                        {
                            if (fourmi.Position.X == unObjet.PositionObjet.X && fourmi.Position.Y == unObjet.PositionObjet.Y)
                            {
                                if (unObjet.GetType() == typeof(Pheromone))
                                {
                                    PrendreObjet(unObjet);
                                    DeposerPheromone(uneZone);
                                    uneZone.LstObjets.Remove(unObjet);                 // Envlève un objet dans la liste d'objets de la zone
                                }
                            }
                            else
                            {
                                fourmi.Destination = new Coordonnee(x, y);
                                Avancer();
                            }
                        }
                    }
                }
            }
        }

        public override void RechercherEnnemi(ZoneAbstraite uneZone)
        {
            if (uneZone.LstObjets.Count > 0)
            {
                for (int x = fourmi.Position.X; x <= uneZone.LimitX; x++)
                {
                    for (int y = fourmi.Position.Y; y <= uneZone.LimitY; y++)
                    {
                        foreach (PersonnageAbstrait unPersonnage in uneZone.LstPersonnages)
                        {
                            if (fourmi.Position.X == unPersonnage.Position.X && fourmi.Position.Y == unPersonnage.Position.Y)
                            {
                                if (unPersonnage.GetType() != typeof(Fourmi))
                                {
                                    fourmi.NotifierObs();       //Notifier les fourmis combattants
                                    DeposerPheromone(uneZone);
                                }
                            }
                            else
                            {
                                fourmi.Destination = new Coordonnee(x, y);
                                Avancer();
                            }
                        }
                    }
                }
            }
        }

        public override void Avancer()
        {
            base.Avancer();
        }

        public override void MangerObjet(ObjetAbstrait unObjet)
        {
            base.MangerObjet(unObjet);
        }

        public override void PrendreObjet(ObjetAbstrait unObjet)
        {
            fourmi.LstObjets.Add(unObjet);          
        }

        public override void DeposerPheromone(ZoneAbstraite uneZone)
        {
            Pheromone pheromone = fabrique.Creer(this.fourmi.Position);
            uneZone.LstObjets.Add(pheromone);
            fourmi.NotifierObs();
        }

        public override void Mourir()
        {
            base.Mourir();
        }

        public override void AjouterPersonnage(ZoneAbstraite zone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void SupprimerPersonnage()
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void ChoixZoneSuivante(ZoneAbstraite zone)
        {
            base.ChoixZoneSuivante(zone);
        }

        public override void Combattre(PersonnageAbstrait ennemi)
        {
            Console.WriteLine("Opération non autorisée");
        }
        
    }
}
