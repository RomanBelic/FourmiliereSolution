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
        public Combattante(int id, string unNom) : base(id, unNom)
        {
            this.Comportement = new ComportementCombattante();
        }
    }
}
