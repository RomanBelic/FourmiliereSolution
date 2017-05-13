using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using LibAbstraite.GestionObjets;

namespace LibMetier.GestionObjets
{
    public class FabriqueConcreteOeuf : FabriqueAbstraiteObjet
    {
        public override ObjetAbstrait CreerObjet(string nom)
        {
            return new Oeuf(nom);
        }
    }
}
