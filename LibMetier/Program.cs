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
            FabriqueOeuf fo = FabriqueOeuf.GetInstance();
            Oeuf o = fo.Creer();
            Oeuf o2 = fo.Creer();
            
            Fourmi f = new Combattante();
            f.Comportement = new ComportementCueilleuse(f);
            f.Comportement.Cast<ComportementFourmi>().AjouterPersonnage(null);

            Console.WriteLine("Test");
            Console.WriteLine(o.Id + " " +  o2.Id);

            Console.ReadKey();
            //Commit roman
            //qs
        }
    }
}
