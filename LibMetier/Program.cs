﻿using System;
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
            ObjetAbstrait nourriture = new Nourriture("N");
            Combattante combattante = new Combattante();
            combattante.Comportement.Cast<ComportementCombattante>().Combattre();
            
            Console.ReadKey();
            //Commit roman
            //qs
        }
    }
}
