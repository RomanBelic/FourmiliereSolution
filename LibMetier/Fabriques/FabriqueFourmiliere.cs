using System;
using LibAbstraite;
using LibAbstraite.GestionObjets;
using LibMetier.GestionObjets;

namespace LibMetier
{
    public class FabriqueFourmi : FabriqueAbstraite<Fourmi>
    {
        public override Fourmi CreerObjet()
        {
            throw new NotImplementedException();
        }
    }
}
