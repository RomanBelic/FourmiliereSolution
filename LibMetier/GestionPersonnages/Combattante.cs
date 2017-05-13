using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionPersonnages
{
    public class Combattante : PersonnageAbstrait
    {
        public Combattante(string unNom) : base(unNom)
        {
        }
        
        public override void AjoutePersonnage(PersonnageAbstrait unPersonnage)
        {
            throw new NotImplementedException();
        }

        public override ZoneAbstraite ChoixZoneSuivante(List<AccesAbstrait> accesList)
        {
            throw new NotImplementedException();
        }

        public override void prendreUnObjet(ObjetAbstrait unObjet)
        {
            throw new NotImplementedException();
        }

        public override PersonnageAbstrait retournerPersonnage(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }

        public override void SupprimePersonnage(PersonnageAbstrait unPersonnage)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Combattante : " + unNom;
        }
    }
}
