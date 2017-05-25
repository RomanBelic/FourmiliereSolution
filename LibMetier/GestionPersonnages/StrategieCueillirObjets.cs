using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionPersonnages
{
    class StrategieCueillirObjets : StrategieAbstraite
    {
        public override void MettreEnOeuvre()
        {
            Conole.WriteLine("Cueillir...");
        }
    }
}
