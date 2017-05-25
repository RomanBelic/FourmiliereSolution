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

        private ComportementFourmi comportement;
        public ComportementFourmi Comportement { get => comportement; set => comportement = value; }

        public Fourmi() : base()
        {
            this.Comportement = new ComportementFourmi();
        }

        public class FourmiBuilder
        {
            private Fourmi fourmi;

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

            public FourmiBuilder BuildComportement(ComportementFourmi comportement)
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
                this.fourmi.ListObjets = lstObjets;
                return this;
            }

            public Fourmi Build()
            {
                return new Fourmi(this);
            }

        }
    }
}
