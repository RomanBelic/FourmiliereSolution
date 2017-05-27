using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using static LibMetier.Fourmi;

namespace LibMetier
{
    class Program
    {
        static void Main(string[] args)
        {
            Fourmi f = new Combattante();
            f.AttacherObs(new Fourmi() { Observable = f});
            f.Etat = new EtatAvance();
            f.NotifierObs();

            Console.ReadKey();
            //Commit roman
            //qs
        }

    }

}
