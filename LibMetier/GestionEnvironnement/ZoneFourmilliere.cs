using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class ZoneFourmilliere : ZoneAbstraite
    {
        public ZoneFourmilliere(int x, int y, int uniteTaille) : base(x, y, "Terrain fourmilliere", uniteTaille)
        {

        }

        public ZoneFourmilliere()
        {

        }

        public override void AjouterPersonnage(PersonnageAbstrait personnage)
        {
            this.LstPersonnages.Add(personnage);
            personnage.Zone = this;
        }

        public override void SupprimerPersonnage(PersonnageAbstrait personnage)
        {
            this.LstPersonnages.Remove(personnage);
            personnage.Zone = new ZoneEmpty();
        }

        public ZoneFourmilliere(ZoneFourmilliereBuilder builder)
        {
            this.LimitX = builder.Zone.LimitX;
            this.LimitY = builder.Zone.LimitY;
            this.Nom = builder.Zone.Nom;
            this.UniteTaille = builder.Zone.UniteTaille;
            this.LstObjets  = builder.Zone.LstObjets;
            this.LstPersonnages = builder.Zone.LstPersonnages;
        }

        public class ZoneFourmilliereBuilder
        {
            private ZoneAbstraite zone;
            public ZoneAbstraite Zone { get => zone; }

            public ZoneFourmilliereBuilder()
            {
                this.zone = new ZoneFourmilliere();
            }

            public ZoneFourmilliereBuilder buildLimitX(int LimX)
            {
                this.zone.LimitX = LimX;
                return this;
            }

            public ZoneFourmilliereBuilder buildLimitY(int LimY)
            {
                this.zone.LimitY = LimY;
                return this;
            }

            public ZoneFourmilliereBuilder buildNom(string Nom)
            {
                this.zone.Nom = Nom;
                return this;
            }

            public ZoneFourmilliereBuilder buildUniteTaille(int UniteTaille)
            {
                this.zone.UniteTaille = UniteTaille;
                return this;
            }

            public ZoneFourmilliereBuilder buildLstObjets(List<ObjetAbstrait> lstObjetsAbstrait)
            {
                this.zone.LstObjets = lstObjetsAbstrait;
                return this;
            }

            public ZoneFourmilliereBuilder buildLstPersonnages(List<PersonnageAbstrait> lstPersonnages)//
            {
                this.zone.LstPersonnages = lstPersonnages;
                return this;
            }

            public ZoneFourmilliere Build()
            {
                return new ZoneFourmilliere(this);
            }

        }
    }
}
