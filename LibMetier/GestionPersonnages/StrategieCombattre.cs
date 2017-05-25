using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionPersonnages
{
    public class StrategieCombattre : StrategieAbstraite
    {
        public override void MettreEnOeuvre()
        {
            Console.WriteLine("Combattre...");
        }
    }
}
