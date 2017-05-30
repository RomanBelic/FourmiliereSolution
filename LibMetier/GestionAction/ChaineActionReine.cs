using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ChaineActionReine : ChaineAction<Reine, Simulateur<Fourmi>>
    {
        public ChaineActionReine(Predicate<Simulateur<Fourmi>> predicate, Executable<Reine> executable) : 
            base(predicate, executable)
        {   

        }

    }
}
