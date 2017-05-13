using System.Collections.Generic;

namespace LibAbstraite
{
    public abstract class ZoneAbstraite 
    {
        public string Nom { get; set; }
        public List<ObjetAbstrait> ObjetsList { get; set; }
        public List<PersonnageAbstrait> listPersonnages { get; set; }

        public ZoneAbstraite(string unNom)
        {
            this.Nom = unNom;
        }

        public abstract void AjouteAcces(AccesAbstrait acces);
        
        public void AjouteObjet(ObjetAbstrait unObjet)
        {
            ObjetsList.Add(unObjet);
        }

        public void AjoutePersonnage(PersonnageAbstrait unPersonnage)
        {
            listPersonnages.Add(unPersonnage);
        }

        public void RetirerPersonnage(PersonnageAbstrait unPersonnage)
        {
            listPersonnages.Remove(unPersonnage);
        }
    }
}