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

        public virtual void PrendreObjet(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public virtual void Avancer()
        {
            if (!fourmi.Position.Equals(fourmi.Destination))
            {
                if (fourmi.Position.X != fourmi.Destination.X)
                    fourmi.Position.X += (fourmi.Position.X - fourmi.Destination.X) > 0 ? fourmi.Zone.UniteTaille : -fourmi.Zone.UniteTaille;
                if (fourmi.Position.Y != fourmi.Destination.Y)
                    fourmi.Position.Y += (fourmi.Position.Y - fourmi.Destination.Y) > 0 ? fourmi.Zone.UniteTaille : -fourmi.Zone.UniteTaille;
                this.fourmi.ChangeEtat();
            }
            else
            {
                this.fourmi.Etat = new EtatAttente();
            }
            this.fourmi.NotifierObs();
        }

        public virtual void Mourir()
        {
            throw new NotImplementedException();
        }

        public virtual void Manger()
        {
            throw new NotImplementedException();
        }

        public override void SupprimerPersonnage()
        {
            throw new NotImplementedException();
        }

        public override void ChoixZoneSuivante(ZoneAbstraite zone)
        {
            throw new NotImplementedException();
        }

        public override void AjouterPersonnage(ZoneAbstraite zone)
        {
            throw new NotImplementedException();
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
