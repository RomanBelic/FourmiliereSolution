using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using LibAbstraite.GestionObjets;

namespace LibMetier.GestionObjets
{
    public class FabriqueConcreteOeuf : FabriqueAbstraiteObjet<Oeuf>
    {
        public override Oeuf CreerObjet(string nom)
        {
            return new Oeuf(nom);
        }
    }
}
