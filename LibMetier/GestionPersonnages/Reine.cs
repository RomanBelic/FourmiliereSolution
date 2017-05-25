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
        public Reine(int id, string unNom) : base(id, unNom)
        {
            this.Comportement = new ComportementReine();
        }
    }
}
