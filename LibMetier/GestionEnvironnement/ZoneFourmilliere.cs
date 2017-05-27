using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ZoneFourmilliere : ZoneAbstraite
    {
        public ZoneFourmilliere(int x, int y) : base(x, y, "Terrain fourmilliere")
        {

        }

        public override void AjouterPersonnage(PersonnageAbstrait personnage)
        {
            this.LstPersonnages.Add(personnage);
        }

        public override void SupprimerPersonnage(PersonnageAbstrait personnage)
        {
            this.LstPersonnages.Remove(personnage);
        }
    }
}
