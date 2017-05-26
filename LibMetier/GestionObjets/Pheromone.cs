using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionObjets
{
    class Pheromone : ObjetAbstrait
    {
        public Pheromone(int Id, string NomStr) : base(Id, "Phéromone")
        {
        }
    }
}
