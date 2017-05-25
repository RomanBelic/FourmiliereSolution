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

        public EtatAbstrait(int idFlag, string nameStr)
        {
            this.idFlag = idFlag;
            this.nameStr = nameStr;
        }

        public override int GetHashCode()
        {
            return new  { idFlag, nameStr }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is EtatAbstrait && this.KeyComparer.Equals(((EtatAbstrait)obj).KeyComparer);
        }
    }
}
