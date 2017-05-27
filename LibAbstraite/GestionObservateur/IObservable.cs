using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
   public interface IObservable<T>
   {
        void AttacherObs(IObserver<T> observer);
        void DetacherObs(IObserver<T> observer);
        void NotifierObs();
    }
}
