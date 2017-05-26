using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
   public class ComportementCombattante : ComportementFourmi
   {
        public ComportementCombattante(Fourmi fourmi) : base(fourmi)
        {
        }

        public override void Combattre(PersonnageAbstrait ennemi)
        {
            //base.Combattre(ennemi);
            Console.WriteLine("Combattre ennemi :" + ennemi.Nom);
        }
    }
}
