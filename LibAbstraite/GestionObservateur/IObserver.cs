using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public interface IObserver<T>
    {
        void OnMiseAJour(T observable);
    }
}
