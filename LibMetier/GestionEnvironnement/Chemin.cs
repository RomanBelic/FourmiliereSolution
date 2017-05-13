using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Chemin : AccesAbstrait
    {

        public Chemin(ZoneAbstraite zdebut, ZoneAbstraite zfin) : base(zdebut, zfin)
        {
        }

    }
}
