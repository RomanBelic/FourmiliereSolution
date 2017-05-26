using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
    class FabriqueNourriture : FabriqueAbstraite<Nourriture>
    {
        public override Nourriture Creer()
        {
            throw new NotImplementedException();
        }
    }
}
