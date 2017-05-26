using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
    public class FabriqueOeuf : FabriqueAbstraite<Oeuf>
    {
        private static readonly FabriqueOeuf instance = new FabriqueOeuf();
        private int idGenerator;
        private FabriqueOeuf()
        {
            this.idGenerator = 0;
        }

        public static FabriqueOeuf GetInstance()
        {
            return instance;
        }

        public override Oeuf Creer()
        {
            idGenerator++;
            return new Oeuf(idGenerator);
        }
    }
}
