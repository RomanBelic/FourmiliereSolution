﻿using System;
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
            //if (ContientObjet(uneZone))
            //{
            //    PrendreObjet(uneZone);
            //}
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

        public override bool ContientObjet(ZoneAbstraite uneZone)
        {
            Console.WriteLine("Rechercher un objet...");

            if (uneZone.LstObjets.Count != 0)
            {
                Console.WriteLine("Au moins un objet trouvé dans cette zone... "+uneZone.Nom);
                return true;
            }
            Console.WriteLine("Pas d'objet trouvé dans cette zone... "+uneZone.Nom);
            return false;
        }
    }
}
