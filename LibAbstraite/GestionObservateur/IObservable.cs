using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
   public interface IObservable
   {
        void AttacherObs(IObserver observer);
        void DetacherObs(IObserver observer);
        void NotifierObs();
    }

    public class ObservableEmpty : PersonnageAbstrait
    {
        protected override object KeyComparer => throw new NotImplementedException();

        public override void MettreAJour()
        {
            Console.WriteLine("Operation imbossible");
        }
    }
}
