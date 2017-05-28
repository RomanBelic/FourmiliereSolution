using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class SimulateurFourmi : LibAbstraite.IObserver<Fourmi>
    {
        private static SimulateurFourmi instance = new SimulateurFourmi();


        private SimulateurFourmi()
        {

        }

        public static SimulateurFourmi GetInstance()
        {
            return instance;
        }

        public void OnMiseAJour(Fourmi observable)
        {
            Console.WriteLine(String.Format("Notification par : {0}", observable.ToString()));
        }
    }
}
