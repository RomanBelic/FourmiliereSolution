using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Combattante : Fourmi
    {
        public Combattante() : base()
        {
            this.Comportement = new ComportementCombattante();
        }
    }
}
