using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ChaineActionFourmi : ChaineAction<Fourmi, Simulateur<Fourmi>>
    {
        public ChaineActionFourmi(Predicate<Simulateur<Fourmi>> predicate, Executable<Fourmi> executable) : base(predicate, executable)
        {
        }
    }
}
