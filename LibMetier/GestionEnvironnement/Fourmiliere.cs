using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Fourmiliere : EnvironnementAbstrait
    {
       
        public Fourmiliere()
        {

        }

        public override List<ObjetAbstrait> listObjets { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<PersonnageAbstrait> listPersonnages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AjouteChemins(FabriqueAbstraite fabrique, params AccesAbstrait[] accesArray)
        {
            throw new NotImplementedException();
        }

        public override void AjouteZoneAbstraits(params ZoneAbstraite[] zoneAbstraitsArray)
        {
            throw new NotImplementedException();
        }

        public override void DeplacerPersonnage(PersonnageAbstrait unPersonnage, ZoneAbstraite zoneSource, ZoneAbstraite zoneDestination)
        {
            throw new NotImplementedException();
        }
    }
}
