using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Reine : Fourmi
    {
        public Reine() : base() 
        {
            this.Comportement = new ComportementReine(this);
        }

        public ComportementReine GetComportementReine() { return this.Comportement.Cast<ComportementReine>(); }
    }
}
