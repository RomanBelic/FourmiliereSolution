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

        public Fourmi() : base()
        {
            this.Comportement = new ComportementFourmi(this);
        }

        public override void MettreAJour()
        {
            throw new NotImplementedException();
        }

        public Fourmi(FourmiBuilder builder)
        {
            this.Comportement = builder.fourmi.Comportement;
            this.Etat = builder.fourmi.Etat;
            this.Id = builder.fourmi.Id;
            this.Nom = builder.fourmi.Nom;
            this.PointDeVie = builder.fourmi.PointDeVie;
            this.Zone = builder.fourmi.Zone;
            
        }

        public class FourmiBuilder
        {
            public Fourmi fourmi;

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

            public FourmiBuilder BuildComportement(ComportementAbstrait comportement)
            {
                this.fourmi.Comportement = comportement;
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
            public FourmiBuilder BuildObservateurs(List<IObserver> lstObservers)
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
