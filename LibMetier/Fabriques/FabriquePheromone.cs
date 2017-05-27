using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    class FabriquePheromone : FabriqueAbstraite<Pheromone>
    {
        private static readonly FabriquePheromone instance = new FabriquePheromone();
        private int idGenerator;

        private FabriquePheromone()
        {
            this.idGenerator = 0;
        }

        public static FabriquePheromone GetInstance()
        {
            return instance;
        }

        public override Pheromone Creer()
        {
            idGenerator++;
            return new Pheromone(idGenerator);
        }
    }
}
