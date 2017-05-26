using System;
using LibAbstraite;

namespace LibMetier
{
    public class FabriqueFourmi : FabriqueAbstraite<Fourmi>
    {
        public override Fourmi Creer()
        {
            throw new NotImplementedException();
        }
    }
}
