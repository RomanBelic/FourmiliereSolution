using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Pheromone : ObjetAbstrait
    {
        public Pheromone(int Id) : base(Id, "Phéromone")
        {
        }

        public Pheromone(int Id, Coordonnee position) : this(Id)
        {
            this.PositionObjet = position;
        }

        protected override object KeyComparer => Id;
    }
}
