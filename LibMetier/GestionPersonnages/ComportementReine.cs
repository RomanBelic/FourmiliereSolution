using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
    public class ComportementReine : ComportementFourmi
    {
        private FabriqueFourmi fabrique = FabriqueFourmi.GetInstance();

        public ComportementReine(Fourmi fourmi) : base(fourmi)
        {
        }

        public override Fourmi CreerFourmi()
        {
            Coordonnee position = new Coordonnee(fourmi.Position.X, fourmi.Position.Y);
            Fourmi spawn = fabrique.Creer(fourmi.Zone, position);
            spawn.Comportement = new ComportementFourmi(spawn);
            return spawn;
        }

        public override void MangerObjet(ObjetAbstrait unObjet)
        {
            base.MangerObjet(unObjet);
        }

        public override void Nourrir(Fourmi fourmi)
        {
            foreach(ObjetAbstrait unObjet in fourmi.Zone.LstObjets)
            {
                if(unObjet.GetType() == typeof(Nourriture))
                {
                    MangerObjet(unObjet);
                    break;  // Pour ne pas que la fourmi mange tous les objets "Nourriture" de la zone
                }
            }
        }

        public override void RechercherObjet(ZoneAbstraite uneZone)
        {
            if (uneZone.LstObjets.Count > 0)
            {
                for (int x = fourmi.Position.X; x <= uneZone.LimitX; x++)
                {
                    for (int y = fourmi.Position.Y; y <= uneZone.LimitY; y++)
                    {
                        foreach (ObjetAbstrait unObjet in uneZone.LstObjets)
                        {
                            if (fourmi.Position.X == unObjet.PositionObjet.X && fourmi.Position.Y == unObjet.PositionObjet.Y)
                            {
                                if (unObjet.GetType() == typeof(Pheromone))
                                {
                                    PrendreObjet(unObjet);
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

        public override void Avancer()
        {
            base.Avancer();
        }

        public override void Mourir()
        {
            base.Mourir();
        }

        public override void ChoixZoneSuivante(ZoneAbstraite zone)
        {
            base.ChoixZoneSuivante(zone);
        }

        public override void Combattre(PersonnageAbstrait ennemi)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void Creuser(ZoneAbstraite uneZone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void DeposerPheromone(ZoneAbstraite uneZone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void AjouterPersonnage(ZoneAbstraite zone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void SupprimerPersonnage()
        {
            Console.WriteLine("Opération non autorisée");
        }

        
    }
}
