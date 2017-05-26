using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionPersonnages
{
    public class Reine : Fourmi
    {
        public Reine() : base()
        {
            this.Comportement = new ComportementReine();
        }
    }
}
