using LibAbstraite;
using LibMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFourmilliere
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulateurFourmi sf = SimulateurFourmi.GetInstance();
            var zone = sf.FabriqueZone.Creer();
            var reine = sf.FabriqueFourmi.Creer(zone, new Coordonnee(0,0));
            reine.Comportement = new ComportementReine(reine);
            zone.AjouterPersonnage(reine);
            reine.AttacherObs(sf);


            Console.WriteLine(zone.LstPersonnages.Count + "");
            Console.ReadKey();
        }

    }
}
