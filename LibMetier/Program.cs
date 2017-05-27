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
            f.Observable = new Fourmi() { Etat = new EtatAdult() };
            f.MettreAJour();

            Console.ReadKey();
            //Commit roman
            //qs
        }

    }

}
