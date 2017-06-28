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
        protected override object KeyComparer => this.Id;
        public int tourFourmi;
        public Boolean trouver = false;
        protected int TourFourmi { get => tourFourmi; set => tourFourmi = value; }

        public Fourmi() : base()
        {
            this.Comportement = new ComportementFourmi(this);
            this.Etat = CollectionEtat.EtatFourmi;
            this.PointDeVie = 100;
        }

        public Fourmi(int Id) : this()
        {
            this.Id = Id;
        }

        public ComportementFourmi GetComportementFourmi() { return this.Comportement.Cast<ComportementFourmi>(); }

        public override void OnMiseAJour(PersonnageAbstrait observable)
        {
             Console.WriteLine(String.Format("Notification par {0}",observable.ToString()));
        }

        public Fourmi(FourmiBuilder builder)
        {
            this.Comportement = new ComportementFourmi(this);
            this.Etat = builder.Fourmi.Etat;
            this.Id = builder.Fourmi.Id;
            this.Nom = builder.Fourmi.Nom;
            this.PointDeVie = builder.Fourmi.PointDeVie;
            this.Zone = builder.Fourmi.Zone;
            this.LstObservers = builder.Fourmi.LstObservers;
            this.Position = builder.Fourmi.Position;
        }

        public class FourmiBuilder
        {
            private Fourmi fourmi;
            public Fourmi Fourmi { get => fourmi ;}

            public FourmiBuilder()
            {
                this.fourmi = new Fourmi();
            }

            public FourmiBuilder BuildId(int Id)
            {
                this.fourmi.Id = Id;
                return this;
            }

            public FourmiBuilder BuildPointVie(int PointVie)
            {
                this.fourmi.PointDeVie = PointVie;
                return this;
            }

            public FourmiBuilder BuildPosition(Coordonnee position)
            {
                this.fourmi.Position = position;
                return this;
            }

            public FourmiBuilder BuildZone(ZoneAbstraite Zone)
            {
                this.fourmi.Zone = Zone;
                return this;
            }

            public FourmiBuilder BuildNom(string Nom)
            {
                this.fourmi.Nom = Nom;
                return this;
            }

            public FourmiBuilder BuildObjects(List<ObjetAbstrait> lstObjets)
            {
                this.fourmi.LstObjets = lstObjets;
                return this;
            }

            public FourmiBuilder BuildEtat(EtatAbstrait Etat)
            {
                this.fourmi.Etat = Etat;
                return this;
            }
            public FourmiBuilder BuildObservateurs(List<LibAbstraite.IObserver<PersonnageAbstrait>> lstObservers)
            {
                this.fourmi.LstObservers = lstObservers;
                return this;
            }

            public Fourmi Build()
            {
                return new Fourmi(this);
            }
        }
    }
}
