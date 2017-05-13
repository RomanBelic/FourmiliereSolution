using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite.GestionObjets
{
    public abstract class FabriqueAbstraiteObjet
    {
        public abstract ObjetAbstrait CreerObjet(string nom);
    }
}
