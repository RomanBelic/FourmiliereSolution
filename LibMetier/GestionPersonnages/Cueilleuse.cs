using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Cueilleuse : Fourmi
    {
        private ObjetAbstrait unObjet;

        public Cueilleuse() : base()
        {
            this.Comportement = new ComportementCueilleuse();
        }
    }
}
