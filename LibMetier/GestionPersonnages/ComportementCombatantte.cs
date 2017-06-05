using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
   public class ComportementCombattante : ComportementFourmi
   {
        public ComportementCombattante(Fourmi fourmi) : base(fourmi)
        {
        }

        public override void Combattre(PersonnageAbstrait ennemi)
        {
            Console.WriteLine("Combattre ennemi :" + ennemi.Nom);
            fourmi.Zone.LstPersonnages.Remove(ennemi);
            ennemi.Etat = CollectionEtat.EtatMort;
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
                                    uneZone.LstObjets.Remove(unObjet);                 // Envlève l'objet trouvé de la liste d'objets de la zone
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
                                    Combattre(unPersonnage);
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

        public override void MangerObjet(ObjetAbstrait unObjet)
        {
            base.MangerObjet(unObjet);
        }

        public override void PrendreObjet(ObjetAbstrait unObjet)
        {
            base.PrendreObjet(unObjet);
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

        public override void AjouterPersonnage(ZoneAbstraite zone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void SupprimerPersonnage()
        {
            base.SupprimerPersonnage();
        }

        public override void DeposerPheromone(ZoneAbstraite uneZone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void Nourrir(Fourmi fourmi)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void Creuser(ZoneAbstraite uneZone)
        {
            Console.WriteLine("Opération non autorisée");
        }
    }
}
