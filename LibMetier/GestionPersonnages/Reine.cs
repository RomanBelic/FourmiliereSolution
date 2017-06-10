using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Reine : Fourmi
    {
        public Reine() : base()
        {
            this.Comportement = new ComportementReine(this);
        }

        public ComportementReine GetComportementReine() { return this.Comportement.Cast<ComportementReine>(); }

        public Reine(ReineBuilder builder)
        {
            this.Comportement = new ComportementReine(this);
            this.Etat = builder.Fourmi.Etat;
            this.Id = builder.Fourmi.Id;
            this.Nom = builder.Fourmi.Nom;
            this.PointDeVie = builder.Fourmi.PointDeVie;
            this.Zone = builder.Fourmi.Zone;
            this.LstObservers = builder.Fourmi.LstObservers;
            this.Position = builder.Fourmi.Position;
        }

        public class ReineBuilder
        {
            private Reine fourmi;
            public Reine Fourmi { get => fourmi; }

            public ReineBuilder()
            {
                this.fourmi = new Reine();
            }

            public ReineBuilder BuildId(int Id)
            {
                this.fourmi.Id = Id;
                return this;
            }

            public ReineBuilder BuildPointVie(int PointVie)
            {
                this.fourmi.PointDeVie = PointVie;
                return this;
            }

            public ReineBuilder BuildPosition(Coordonnee position)
            {
                this.fourmi.Position = position;
                return this;
            }

            public ReineBuilder BuildZone(ZoneAbstraite Zone)
            {
                this.fourmi.Zone = Zone;
                return this;
            }

            public ReineBuilder BuildNom(string Nom)
            {
                this.fourmi.Nom = Nom;
                return this;
            }

            public ReineBuilder BuildObjects(List<ObjetAbstrait> lstObjets)
            {
                this.fourmi.LstObjets = lstObjets;
                return this;
            }

            public ReineBuilder BuildEtat(EtatAbstrait Etat)
            {
                this.fourmi.Etat = Etat;
                return this;
            }
            public ReineBuilder BuildObservateurs(List<LibAbstraite.IObserver<PersonnageAbstrait>> lstObservers)
            {
                this.fourmi.LstObservers = lstObservers;
                return this;
            }

            public Reine Build()
            {
                return new Reine(this);
            }
        }
    }
}
