using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ComportementReine : ComportementFourmi
    {
        public ComportementReine(Fourmi fourmi) : base(fourmi)
        {
        }

        public override Fourmi CreerFourmi()
        {
            return base.CreerFourmi();
        }
    }
}
