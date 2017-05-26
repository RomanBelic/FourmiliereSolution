using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public enum EtatFlags { Vivant = 0, Mort = 1, EnAttente = 2, EtatAdult = 3, EtatOeuf = 4, EtatAvance = 5, Default = -1}

    public class EtatFourmi : EtatAbstrait
    {
        protected override object KeyComparer => IdFlag;

        public EtatFourmi(int idFlag, string nameStr) : base(idFlag, nameStr)
        {
        }
    }

    public class EtatEnVie : EtatFourmi
    {
        public EtatEnVie() : base((int)EtatFlags.Vivant, "Vivante")
        {
        }
    }

    public class EtatMort : EtatFourmi
    {
        public EtatMort() : base((int)EtatFlags.Mort, "Morte")
        {
        }
    }

    public class EnAttente : EtatFourmi
    {
        public EnAttente() : base((int)EtatFlags.EnAttente, "En Attente")
        {
        }
    }
    public class EtatAdult : EtatFourmi
    {
        public EtatAdult() : base((int)EtatFlags.EtatAdult, "Adult")
        {
        }
    }
    public class EtatOeuf : EtatFourmi
    {
        public EtatOeuf() : base((int)EtatFlags.EtatOeuf, "Oeuf")
        {
        }
    }

    public class EtatAvance : EtatFourmi
    {
        public EtatAvance() : base((int)EtatFlags.EtatAvance, "En train d'avancer")
        {
        }
    }
}
