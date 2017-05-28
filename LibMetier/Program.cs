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
            FabriqueZone fz = FabriqueZone.GetInstance();
            ZoneAbstraite zone = fz.Creer();

            Reine reine = new Reine();
            reine.Zone = zone;
            
            Reine reine2 = new Reine();
            reine2.Comportement = new ComportementReine(reine2);

            Fourmi f = reine.Comportement.Cast<ComportementReine>().CreerFourmi();
            Fourmi f2 = reine.Comportement.Cast<ComportementReine>().CreerFourmi();
            Fourmi f3 = reine.Comportement.Cast<ComportementReine>().CreerFourmi();
            Fourmi f4 = reine2.Comportement.Cast<ComportementReine>().CreerFourmi();
            reine2.Comportement = new ComportementReine(reine2);
            Fourmi f5 = reine2.Comportement.Cast<ComportementReine>().CreerFourmi();
            f5.AttacherObs(reine);
            f5.Destination = new Coordonnee(2, 2);
            f5.Etat = CollectionEtat.EtatAdult;
            f5.Comportement.Cast<ComportementFourmi>().Avancer();
         
            Console.WriteLine(f.Id );
            Console.WriteLine(f2.Id);
            Console.WriteLine(f3.Id);
            Console.WriteLine(f5.Etat.ToString() );

            Console.ReadKey();
            //Commit roman
            //qs
        }

    }

}
