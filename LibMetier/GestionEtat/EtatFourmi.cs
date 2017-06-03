using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public enum EtatFlags { Vivant = 0, Mort = 1, EnAttente = 2, EtatAdult = 3, EtatOeuf = 4, EtatAvance = 5, Default = -1, EtatFourmi = 6}

    public class EtatFourmi : EtatAbstrait
    {
        protected override object KeyComparer => IdFlag;

        public EtatFourmi(int idFlag, string nameStr) : base(idFlag, nameStr)
        {
        }

        public EtatFourmi() : base((int)EtatFlags.EtatFourmi, "Fourmi initialisée")
        {
        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            personnage.Etat = CollectionEtat.EtatOeuf;
        }
    }

    public class EtatEnVie : EtatFourmi
    {
        public EtatEnVie() : base((int)EtatFlags.Vivant, "Vivante")
        {
        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            personnage.Etat = CollectionEtat.EtatMort;
        }
    }

    public class EtatMort : EtatFourmi
    {
        public EtatMort() : base((int)EtatFlags.Mort, "Morte")
        {
            Console.WriteLine("Etat Morte");
        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            Console.WriteLine("Comportement non définit");
        }
    }

    public class EtatAttente : EtatFourmi
    {
        public EtatAttente() : base((int)EtatFlags.EnAttente, "En Attente")
        {
            
        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            personnage.Etat = CollectionEtat.EtatAvance;
        }
    }
    public class EtatAdult : EtatFourmi
    {
        public EtatAdult() : base((int)EtatFlags.EtatAdult, "Adult")
        {

        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            personnage.Etat = CollectionEtat.EtatAttente;
        }
    }
    public class EtatOeuf : EtatFourmi
    {
        public EtatOeuf() : base((int)EtatFlags.EtatOeuf, "Oeuf")
        {
            Console.WriteLine("etat oeuf");
        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            personnage.Etat = CollectionEtat.EtatAdult;
        }
    }

    public class EtatAvance : EtatFourmi
    {
        public EtatAvance() : base((int)EtatFlags.EtatAvance, "En train d'avancer")
        {
       
        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            personnage.Etat = CollectionEtat.EtatAttente;   
        }
    }
}
