using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using LibAbstraite.GestionObjets;

namespace LibMetier.GestionObjets
{
    public class FabriqueConcretePheromone : FabriqueAbstraiteObjet<Pheromone>
    {
        public override Pheromone CreerObjet(string nom)
        {
            return new Pheromone(nom);
        }
    }
}
