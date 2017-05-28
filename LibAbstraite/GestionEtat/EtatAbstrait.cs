using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public abstract class EtatAbstrait
    {
        protected abstract object KeyComparer { get; }

        private int idFlag;
        private string nameStr;

        public int IdFlag { get => idFlag; set => idFlag = value; }
        public string NameStr { get => nameStr; set => nameStr = value; }

        public EtatAbstrait(int IdFlag, string NameStr)
        {
            this.idFlag = IdFlag;
            this.nameStr = NameStr;
        }

        public abstract void ChangeEtat(PersonnageAbstrait personnage);

        public override int GetHashCode()
        {
            return new  { idFlag, nameStr }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is EtatAbstrait && this.KeyComparer.Equals(((EtatAbstrait)obj).KeyComparer);
        }

        public override string ToString()
        {
            return String.Format("Etat : {0} {1}", idFlag, nameStr);
        }
    }

    public class EtatEmpty : EtatAbstrait
    {
        protected override object KeyComparer => this.IdFlag;

        public EtatEmpty() : base(-1, String.Empty)
        {
        }

        public override void ChangeEtat(PersonnageAbstrait personnage)
        {
            Console.WriteLine("Comportement non définit");
        }
    }
}
