using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ChaineActionCueilleuse : ChaineAction<Cueilleuse, Simulateur<Fourmi>>
    {
        public ChaineActionCueilleuse(Predicate<Simulateur<Fourmi>> predicate, Executable<Cueilleuse> executable) : base(predicate, executable)
        {
        }
    }
}
