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

        public virtual void PrendreObjet(ObjetAbstrait unObjet)
        {
            if (fourmi.Position.X == unObjet.PositionObjet.X && fourmi.Position.Y == unObjet.PositionObjet.Y)
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
            if (fourmi.Etat.Equals(CollectionEtat.EtatAdult) || fourmi.Etat.Equals(CollectionEtat.EtatAttente))
            {
                if (!fourmi.Position.Equals(fourmi.Destination))
                {
                    if (fourmi.Position.X != fourmi.Destination.X)
                        fourmi.Position.X += (fourmi.Position.X < fourmi.Destination.X) ? fourmi.Zone.UniteTaille : -fourmi.Zone.UniteTaille;
                    if (fourmi.Position.Y != fourmi.Destination.Y)
                        fourmi.Position.Y += (fourmi.Position.Y < fourmi.Destination.Y) ? fourmi.Zone.UniteTaille : -fourmi.Zone.UniteTaille;
                    this.fourmi.ChangeEtat();
                }
                else
                {
                    this.fourmi.Etat = CollectionEtat.EtatAttente;
                }
                this.fourmi.NotifierObs();
            }
        }

        public virtual void Mourir()
        {
            foreach (PersonnageAbstrait personnage in fourmi.Zone.LstPersonnages)
            {
                if (personnage.Id == this.fourmi.Id)
                {
                    fourmi.Zone.SupprimerPersonnage(personnage);
                    personnage.Etat.IdFlag = (int)EtatFlags.Mort;

                    Console.WriteLine("Fourmi de nom " + fourmi.Nom + " : Etat mort");
                }
            }
        }

        public virtual void MangerObjet(Nourriture nourriture)
        {
            if (fourmi.LstObjets.Contains(nourriture))
            {
                fourmi.LstObjets.Remove(nourriture);
                fourmi.PointDeVie++;
            }
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

        public virtual void RechercherEnnemi(ZoneAbstraite uneZone)
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
