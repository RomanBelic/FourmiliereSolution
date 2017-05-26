using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Terrain : ZoneAbstraite
    {
        public Terrain(int x, int y) : base(x, y, "Terrain fourmilliere")
        {

        }

        public override void AjouterPersonnage(PersonnageAbstrait personnage)
        {
            throw new NotImplementedException();
        }

        public override void SupprimerPersonnage(PersonnageAbstrait personnage)
        {
            throw new NotImplementedException();
        }
    }
}
