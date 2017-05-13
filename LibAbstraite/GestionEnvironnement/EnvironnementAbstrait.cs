using System.Collections.Generic;

namespace LibAbstraite
{
    public abstract class EnvironnementAbstrait
    {
        public abstract List<ObjetAbstrait> listObjets { get; set; }
        public abstract List<PersonnageAbstrait> listPersonnages{get; set;}

        public List<AccesAbstrait> listAcces = new List<AccesAbstrait>();
        public List<ZoneAbstraite> listZones = new List<ZoneAbstraite>();
        
        public EnvironnementAbstrait()
        {

        }

        public abstract void AjouteChemins(FabriqueAbstraite fabrique, params AccesAbstrait[] accesArray);

        public void AjouteObjet(ObjetAbstrait unObjet)
        {
            listObjets.Add(unObjet);
        }

        public void AjoutePersonnage(PersonnageAbstrait unPersonnage)
        {
            listPersonnages.Add(unPersonnage);
        }

        public abstract void AjouteZoneAbstraits(params ZoneAbstraite[] zoneAbstraitsArray);

        public void ChargerEnvironnement(FabriqueAbstraite fabrique)
        {

        }

        public void ChargerObjets(FabriqueAbstraite fabrique)
        {

        }

        public void ChargerPersonnage(FabriqueAbstraite fabrique)
        {

        }

        public abstract void DeplacerPersonnage(PersonnageAbstrait unPersonnage, ZoneAbstraite zoneSource, ZoneAbstraite zoneDestination);

        public string Simuler()
        {
            return null;
        }

        public string Statistiques()
        {
            return null;
        }


    }
}