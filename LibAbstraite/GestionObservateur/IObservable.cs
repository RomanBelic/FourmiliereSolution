using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
   public interface IObservable<T>
   {
        void AttacherObs(IObserver observer);
        void DetacherObs(IObserver observer);
        void NotifierObs();
        T GetObservableObject();
    }

    public class ObservableEmpty : IObservable<EtatAbstrait>
    {
        private EtatAbstrait etatEmpty = new EtatEmpty();

        public void AttacherObs(IObserver observer)
        {
            Console.WriteLine("Comportement non définit");
        }

        public void DetacherObs(IObserver observer)
        {
            Console.WriteLine("Comportement non définit");
        }

        public EtatAbstrait GetObservableObject()
        {
            return etatEmpty;
        }

        public void NotifierObs()
        {
            Console.WriteLine("Comportement non définit");
        }
    }
}
