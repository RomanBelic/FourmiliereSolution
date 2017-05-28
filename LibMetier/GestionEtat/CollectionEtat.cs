using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class CollectionEtat
    {
        public static readonly EtatFourmi EtatFourmi = new EtatFourmi();
        public static readonly EtatAdult EtatAdult = new EtatAdult();
        public static readonly EtatAttente EtatAttente = new EtatAttente();
        public static readonly EtatAvance EtatAvance = new EtatAvance();
        public static readonly EtatEnVie EtatEnVie = new EtatEnVie();
        public static readonly EtatMort EtatMort = new EtatMort();
        public static readonly EtatOeuf EtatOeuf = new EtatOeuf();
        public static readonly EtatEmpty EtatEmpty = new EtatEmpty();
    }
}
