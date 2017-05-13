using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Nourriture : ObjetAbstrait
    {
        public Nourriture(string unNom) : base(unNom)
        {
        }
    }
}
