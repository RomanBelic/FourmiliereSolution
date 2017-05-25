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

        public virtual void PrendreObjet(ObjetAbstrait objet)
        {
            throw new NotImplementedException();
        }

        public virtual void Avancer()
        {
            throw new NotImplementedException();
        }

        public virtual void Mourir()
        {
            throw new NotImplementedException();
        }

        public virtual void Manger()
        {
            throw new NotImplementedException();
        }

        //Méthode permettant de casté lorsqu'on change de comportement
        public T Cast<T>() where T : ComportementFourmi             
        {
            return (T)this; 
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
    }
}
