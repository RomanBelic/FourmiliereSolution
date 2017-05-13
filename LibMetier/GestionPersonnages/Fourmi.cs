using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Fourmi : PersonnageAbstrait

    {

        private List<PersonnageAbstrait> listPersonnages = new List<PersonnageAbstrait>();

        public Fourmi(string unNom) : base(unNom)
        {

        }

        public override ZoneAbstraite ChoixZoneSuivante(List<AccesAbstrait> accesList)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Fourmi de nom : " + unNom;
        }

        public override void prendreUnObjet(ObjetAbstrait unObjet)
        {
            listObjets.Add(unObjet);
            Console.WriteLine("La Fourmi " + unNom + " a pris un " + unObjet.Nom);
        }

        public override void AjoutePersonnage(PersonnageAbstrait unPersonnage)
        {
            listPersonnages.Add(unPersonnage);
        }

        public override void SupprimePersonnage(PersonnageAbstrait unPersonnage)
        {
            listPersonnages.Remove(unPersonnage);
        }

        public override PersonnageAbstrait retournerPersonnage(ZoneAbstraite uneZone)
        {
            foreach(PersonnageAbstrait unePersonne in listPersonnages)
            {
                if (unePersonne.uneZone == uneZone) return unePersonne;
            }
            return null;
        }
    }
}
