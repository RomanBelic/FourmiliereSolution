using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
   public class ComportementCombattante : ComportementFourmi
   {
        public virtual void Combattre(PersonnageAbstrait enemie)
        {
            throw new NotImplementedException();
        }
   }
}
