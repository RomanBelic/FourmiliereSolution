using System;
using System.Collections.Generic;

namespace LibAbstraite
{
    public abstract class PersonnageAbstrait
    {
        protected string unNom { get => this.unNom = unNom; set => this.unNom = value; }
        protected int pointDeVie { get => this.pointDeVie = pointDeVie; set => this.pointDeVie = value; }
        protected string etat { get => this.etat = etat; set => this.etat = value; }
        protected Random Hazard;
        
        protected List<ObjetAbstrait> listObjets { get => this.listObjets; set => this.listObjets = value; }
        
        public ZoneAbstraite uneZone{get => this.uneZone; set => this.uneZone = value;}

        public PersonnageAbstrait(string unNom)
        {
            this.unNom = unNom;
            this.pointDeVie = 100;
            this.etat = "En vie";
        }

        public abstract ZoneAbstraite ChoixZoneSuivante(List<AccesAbstrait> accesList);
        public abstract string ToString();

        public abstract void prendreUnObjet(ObjetAbstrait unObjet);

        public abstract void AjoutePersonnage(PersonnageAbstrait unPersonnage);
        public abstract void SupprimePersonnage(PersonnageAbstrait unPersonnage);
        public abstract PersonnageAbstrait retournerPersonnage(ZoneAbstraite uneZone);

    }
}