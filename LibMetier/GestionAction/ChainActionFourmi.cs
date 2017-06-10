using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ChainActionFourmi : ChainAction<Fourmi, SimulateurFourmi>
    {
        public ChainActionFourmi(Predicate<SimulateurFourmi> predicate, Executable<Fourmi> executable) : base(predicate, executable)
        {
        }
    }
}
