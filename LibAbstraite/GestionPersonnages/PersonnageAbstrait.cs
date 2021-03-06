﻿using LibAbstraite;
using System;
using System.Collections.Generic;

namespace LibAbstraite
{
    public abstract class PersonnageAbstrait : IObservable<PersonnageAbstrait>, IObserver<PersonnageAbstrait> //Peut être observateur et observable 
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

        private List<ObjetAbstrait> lstObjets;
        public List<ObjetAbstrait> LstObjets { get => this.lstObjets; set => this.lstObjets = value; }

        private ZoneAbstraite zone;
        public ZoneAbstraite Zone { get => this.zone; set => this.zone = value; }
       
        private Coordonnee position;
        public Coordonnee Position { get => position; set => position = value; }
       
        private Coordonnee destination;
        public Coordonnee Destination { get => destination; set => destination = value; }

        private List<IObserver<PersonnageAbstrait>> lstObservers;
        public List<IObserver<PersonnageAbstrait>> LstObservers { get => lstObservers; set => lstObservers = value; }

        private ComportementAbstrait comportement;
        public ComportementAbstrait Comportement { get => comportement; set => comportement = value; }

        public PersonnageAbstrait()
        {
            this.lstObservers = new List<IObserver<PersonnageAbstrait>>(32);
            this.lstObjets = new List<ObjetAbstrait>(32);
            this.position = new Coordonnee(0, 0);
            this.destination = new Coordonnee(0, 0);
            this.etat = new EtatEmpty();
            this.zone = new ZoneEmpty();
        }

        public void ChangeEtat()
        {
            this.etat.ChangeEtat(this);
        }

        public void AttacherObs(IObserver<PersonnageAbstrait> observer)
        {
            this.lstObservers.Add(observer);
        }

        public void DetacherObs(IObserver<PersonnageAbstrait> observer)
        {
            this.lstObservers.Remove(observer);
        }

        public void NotifierObs()
        {
            lstObservers.ForEach(o => { o.OnMiseAJour(this); });
        }

        public virtual void OnMiseAJour(PersonnageAbstrait observable)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()           // Si Equals retourne true, GetHashCode retourne true et sert à comparer les objets via ==
        {
            return new { KeyComparer, nom }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is PersonnageAbstrait && this.KeyComparer.Equals(((PersonnageAbstrait)obj).KeyComparer);
        }

        public override string ToString()
        {
            return String.Format("Id : {0}, Nom : {1}, {2}, {3}, PV : {4}", this.Id, this.Nom, this.Etat.ToString(), this.Position.ToString(), this.PointDeVie);
        }
    }
}