using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier.GestionObjets
{
    public class FabriqueOeuf : FabriqueAbstraite<Oeuf>
    {
        public override Oeuf Creer()
        {
            throw new NotImplementedException();
        }
    }
}
