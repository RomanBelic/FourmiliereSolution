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

            //tests

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


            SimulateurFourmi sf = SimulateurFourmi.GetInstance();
            Executable<Reine> reineAction = (arg) => { Console.WriteLine("action 1"); };
            Executable<Reine> reineAction2 = (arg) => { Console.WriteLine("action 2"); };
            Executable<Reine> reineAction3 = (arg) => { Console.WriteLine("action 3"); };
            ChaineActionReine chaine = new ChaineActionReine(x => x.CountTours == 0, reineAction);
            ChaineActionReine chain2 = new ChaineActionReine(x => x.CountTours == 2, reineAction2);
            ChaineActionReine chain3 = new ChaineActionReine(x => x.CountTours % 2 == 0, reineAction3);
            chaine.SetNextChaineAction(chain2).SetNextChaineAction(chain3);
            
            while (true)
            {
                chaine.Execute(sf, reine);
                sf.CountTours++;
                if (sf.CountTours == 10)
                    break;
            }

            Fourmi ff = null;
            var t = (Reine)ff;
            var tt = (Fourmi)reine;

            Console.ReadKey();
            //Commit roman

        }

    }

}
