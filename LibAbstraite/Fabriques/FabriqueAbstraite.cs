using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite.GestionObjets;

namespace LibAbstraite
{
    public abstract class FabriqueAbstraite<T>
    {
       public abstract T CreerObjet();
    }
}
