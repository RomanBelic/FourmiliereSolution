using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite.GestionObjets;

namespace LibAbstraite
{
    public abstract class FabriqueAbstraite
    {
        public abstract string Title { get; }

        public abstract AccesAbstrait CreerAcces(ZoneAbstraite zdebut, ZoneAbstraite zfin);
        public abstract EnvironnementAbstrait CreerEnvironnement();
        public abstract ObjetAbstrait CreerObjet(string nom);
        // public abstract FabriqueAbstraiteObjet CreerObjet(ObjetAbstrait unObjet);
        public abstract ObjetAbstrait CreerObjet(FabriqueAbstraiteObjet fabrique, string nom);
        public abstract PersonnageAbstrait CreerPersonnage(string nom);
        public abstract ZoneAbstraite CreerZone(string nom);
        
    }
}
