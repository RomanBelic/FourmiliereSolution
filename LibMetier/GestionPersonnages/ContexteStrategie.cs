using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionPersonnages
{
    class ContexteStrategie 
    {
        private StrategieAbstraite strategieCourante;

        public ContexteStrategie(StrategieAbstraite uneStrategie)
        {
            strategieCourante = uneStrategie;
        }

        public void ModifierStrategie(StrategieAbstraite uneStrategie)
        {
            strategieCourante = uneStrategie;

            Console.WriteLine("Strategie courante : " + strategieCourante);
        }

        public void Execute()
        {
            strategieCourante.MettreEnOeuvre();
        }
    }
}
