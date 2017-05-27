﻿using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ComportementFourmi : ComportementAbstrait
    {
        protected Fourmi fourmi;

        public ComportementFourmi(Fourmi fourmi)
        {
            this.fourmi = fourmi;
        }

        public virtual void PrendreObjet(ObjetAbstrait unObjet)
        {
            if(fourmi.Position.X == unObjet.PositionObjet.X && fourmi.Position.Y == unObjet.PositionObjet.Y)
            {
                fourmi.LstObjets.Add(unObjet);
            }
        }

        public virtual void PrendreObjet(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public virtual void Avancer()
        {
            throw new NotImplementedException();
        }

        public virtual void Avancer(Coordonnee positionDestination)
        {
            if (PositionVide(positionDestination))
            {
                fourmi.Position.X = positionDestination.X;
                fourmi.Position.Y = positionDestination.Y;
            }
        }

        public bool PositionVide(Coordonnee unePosition)
        {
            bool returnValue = false;

            foreach(PersonnageAbstrait personnage in fourmi.Zone.LstPersonnages)
            {
                if(unePosition.X == personnage.Position.X && unePosition.Y == personnage.Position.Y)
                {
                    returnValue = false;
                }else returnValue = true;
            }
            return returnValue;
        }

        public virtual void Mourir()
        {
            foreach(PersonnageAbstrait personnage in fourmi.Zone.LstPersonnages)
            {
                if(personnage.Id == this.fourmi.Id)
                {
                    fourmi.Zone.SupprimerPersonnage(personnage);
                    personnage.Etat.IdFlag = (int)EtatFlags.Mort;

                    Console.WriteLine("Fourmi de nom " + fourmi.Nom + " : Etat mort");
                }
            }
        }

        public virtual void MangerObjet(ObjetAbstrait unObjet)
        {
            if (fourmi.LstObjets.Contains(unObjet))
            {
                fourmi.LstObjets.Remove(unObjet);
                fourmi.PointDeVie++;            
            }
        }

        public override void SupprimerPersonnage()
        {
            fourmi.Zone.LstPersonnages.Remove(fourmi);
        }

        public override void ChoixZoneSuivante(ZoneAbstraite zone)
        {
            throw new NotImplementedException();
        }

        public override void AjouterPersonnage(ZoneAbstraite zone)
        {
            zone.LstPersonnages.Add(fourmi);
        }

        public virtual void Combattre(PersonnageAbstrait ennemi)
        {
            throw new NotImplementedException();
        }

        public virtual void Creuser(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public virtual void Nourrir(Fourmi fourmi)
        {
            throw new NotImplementedException();
        }

        public virtual Fourmi CreerFourmi()
        {
            throw new NotImplementedException();
        }

        public virtual void DeposerPheromone(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public virtual void RechercherObjet(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public virtual bool ContientObjet(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public virtual ObjetAbstrait ContientObjet(ObjetAbstrait unObjet, ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

    }
}
