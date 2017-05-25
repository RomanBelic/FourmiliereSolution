using LibAbstraite;
using System;
using System.Collections.Generic;

namespace LibAbstraite
{
    public abstract class PersonnageAbstrait
    {
        protected abstract object KeyComparer {get;}        // Comparer des objets dans une liste

        private int id;
        public int Id { get => id; set => id = value; }

        private string nom;
        public string Nom { get => this.nom; set => this.nom = value; }

        private int pointDeVie;
        public int PointDeVie { get => this.pointDeVie; set => this.pointDeVie = value; }

        private EtatAbstrait etat;
        public EtatAbstrait Etat { get => this.etat; set => this.etat = value; }

        private List<ObjetAbstrait> listObjets;
        public List<ObjetAbstrait> ListObjets { get => this.listObjets; set => this.listObjets = value; }

        private ZoneAbstraite zone;
        public ZoneAbstraite Zone { get => this.zone; set => this.zone = value; }
       
        public PersonnageAbstrait()
        {
        }
 
        public override int GetHashCode()           // Si Equals retourne true, GetHashCode retourne true et sert à comparer les objets via ==
        {
            return new { KeyComparer, nom }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is PersonnageAbstrait && this.KeyComparer.Equals(((PersonnageAbstrait)obj).KeyComparer);
        }
    }
}