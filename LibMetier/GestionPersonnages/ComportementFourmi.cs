using LibAbstraite;
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

        public virtual void PrendreObjet(ObjetAbstrait unObjet, Coordonnee positionObjet)
        {
            fourmi.LstObjets.Add(unObjet);
            fourmi.Position.X = positionObjet.X;
            fourmi.Position.Y = positionObjet.Y;
        }

        public virtual void PrendreObjet(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public bool SeTrouverAutourDunObjet(Fourmi fourmi, ObjetAbstrait unObjet, Coordonnee positionObjet)
        {
            if(fourmi.Position.X == positionObjet.X-1 || fourmi.Position.X == positionObjet.X+1 
                || fourmi.Position.Y == positionObjet.Y-1 || fourmi.Position.Y == positionObjet.Y + 1)
            {
                return true;
            }
            return false;
        }

        public virtual void Avancer()
        {
            throw new NotImplementedException();
        }

        public virtual void Avancer(Coordonnee positionCourante, Coordonnee positionDestination)
        {
            throw new NotImplementedException();
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

        public virtual bool ContientObjet(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

    }
}
