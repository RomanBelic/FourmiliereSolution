using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
   public class ChaineActionCombattante : ChaineAction<Combattante, Simulateur<Fourmi>>
    {
        public ChaineActionCombattante(Predicate<Simulateur<Fourmi>> predicate, Executable<Combattante> executable) : base(predicate, executable)
        {
        }
    }
}
