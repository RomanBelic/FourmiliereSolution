using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
   public class ComportementCueilleuse : ComportementFourmi
   {
        public virtual void Creuser()
        {
            throw new NotImplementedException();
        }

        public virtual void Nourrir(Fourmi fourmi)
        {
            throw new NotImplementedException();
        }

   }
}
