using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
   public interface IObservable
   {
        void Attacher(IObserver observer);
        void Detacher(IObserver observer);
        void Notifier();
    }

    public class ObservableEmpy : IObservable
    {
        public void Attacher(IObserver observer)
        {
            Console.WriteLine("Comportement non définit");
        }

        public void Detacher(IObserver observer)
        {
            Console.WriteLine("Comportement non définit");
        }

        public void Notifier()
        {
            Console.WriteLine("Comportement non définit");
        }
    }
}
