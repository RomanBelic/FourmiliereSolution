using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public abstract class Simulateur : IObserver<PersonnageAbstrait>
    {
        private int countTours;
        public int CountTours { get => countTours; set => countTours = value; }

        public abstract void OnMiseAJour(PersonnageAbstrait observable);
    }
}
