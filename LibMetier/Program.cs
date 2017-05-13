using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetAbstrait nourriture = new Nourriture("N");

            Console.WriteLine(nourriture.GetType());

            Console.ReadKey();
            //Commit roman
        }
    }
}
