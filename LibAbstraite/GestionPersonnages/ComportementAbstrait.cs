using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public abstract class ComportementAbstrait
    {
        public T Cast<T>() where T : ComportementAbstrait
        {
            return (T)this;
        }

    }
}
