using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class BoutDeTerrain : ZoneAbstraite
    {
        public BoutDeTerrain(string unNom) : base(unNom)
        {
        }

        public override void AjouteAcces(AccesAbstrait acces)
        {
            throw new NotImplementedException();
        }
    }
}
