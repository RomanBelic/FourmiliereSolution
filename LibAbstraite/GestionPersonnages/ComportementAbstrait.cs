using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public abstract class ComportementAbstrait
    {
        public abstract void SupprimerPersonnage();
        public abstract void ChoixZoneSuivante(ZoneAbstraite zone);
        public abstract void AjouterPersonnage(ZoneAbstraite zone);
        public T Cast<T>() where T : ComportementAbstrait
        {
            return (T)this;
        }
    }
}
