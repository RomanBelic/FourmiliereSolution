using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
    public class FabriqueNourriture : FabriqueAbstraite<Nourriture>
    {
        private static readonly FabriqueNourriture instance = new FabriqueNourriture();
        private int idGenerator;

        private FabriqueNourriture()
        {
            this.idGenerator = 0;
        }

        public static FabriqueNourriture GetInstance()
        {
            return instance;
        }

        public override Nourriture Creer()
        {
            idGenerator++;
            return new Nourriture(idGenerator);
        }
    }
}
