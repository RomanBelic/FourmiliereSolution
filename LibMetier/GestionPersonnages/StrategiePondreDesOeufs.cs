using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionPersonnages
{
    class StrategiePondreDesOeufs : StrategieAbstraite
    {
        public override void MettreEnOeuvre()
        {
            Console.WriteLine("Pondre des oeufs");
        }
    }
}
