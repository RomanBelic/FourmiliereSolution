using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using static LibMetier.Fourmi;

namespace LibMetier
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulateurFourmi sf = SimulateurFourmi.GetInstance();
              

            Executable<Reine> r = (Reine reine) => { };

            ChaineActionReine cha = new ChaineActionReine(x => x.CountTours == 5, r);
            cha.SetNextChaineAction(cha);
        }
    }
}
