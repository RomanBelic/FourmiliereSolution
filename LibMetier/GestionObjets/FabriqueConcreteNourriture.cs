using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using LibAbstraite.GestionObjets;

namespace LibMetier
{
    class FabriqueConcreteNourriture : FabriqueAbstraiteObjet<Nourriture>
    {
        public override Nourriture CreerObjet(string nom)
        {
            return new Nourriture(nom);
        }
    }
}
