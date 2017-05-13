using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier.GestionPersonnages
{
    public class Cueilleuse : PersonnageAbstrait
    {


        public Cueilleuse(string unNom) : base(unNom)
        {

        }

        public override ZoneAbstraite ChoixZoneSuivante(List<AccesAbstrait> accesList)
        {
            throw new NotImplementedException();
        }

        public override void prendreUnObjet(ObjetAbstrait unObjet)
        {
            listObjets.Add(unObjet);
            Console.WriteLine("La Cueilleuse " + unNom + " a pris un " + unObjet.Nom);
        }

        public override string ToString()
        {
            return "Cueilleuse " + unNom;
        }

        public override void AjoutePersonnage(PersonnageAbstrait unPersonnage)
        {
            throw new NotImplementedException();
        }

        public override void SupprimePersonnage(PersonnageAbstrait unPersonnage)
        {
            throw new NotImplementedException();
        }

        public override PersonnageAbstrait retournerPersonnage(ZoneAbstraite uneZone)
        {
            throw new NotImplementedException();
        }
    }
}
