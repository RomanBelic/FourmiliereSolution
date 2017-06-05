using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class FabriquePheromone : FabriqueAbstraite<Pheromone>
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

        public Pheromone Creer(Coordonnee position)
        {
            idGenerator++;
            Coordonnee posNoReference = new Coordonnee(position.X, position.Y);
            return new Pheromone(idGenerator, posNoReference);
        }
    }
}
