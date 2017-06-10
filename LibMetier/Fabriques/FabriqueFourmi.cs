using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class FabriqueFourmi : FabriqueAbstraite<Fourmi>
    {
        private static readonly FabriqueFourmi instance = new FabriqueFourmi();
        private int idGenerator;
     
        private FabriqueFourmi()
        {
            this.idGenerator = 0;
        }

        public static FabriqueFourmi GetInstance()
        {
            return instance;
        }

        public override Fourmi Creer()
        {
            idGenerator++;
            return new Fourmi(idGenerator);
        }

        public Fourmi Creer(ZoneAbstraite zone, Coordonnee position)
        {
            idGenerator++;
            Coordonnee posNoReference = new Coordonnee(position.X, position.Y);
            int PV = (ConfigurationManager.AppSettings["PointDeVie"] != null) ? Convert.ToInt32(ConfigurationManager.AppSettings["PointDeVie"]) : 100;
            Fourmi fourmi = new Fourmi.FourmiBuilder().
                          BuildEtat(CollectionEtat.EtatOeuf).
                          BuildId(idGenerator).
                          BuildNom("Fourmi " + idGenerator).
                          BuildPointVie(PV).
                          BuildZone(zone).
                          BuildPosition(posNoReference).
                          Build();
            return fourmi;
        }

        public Reine CreerReine(ZoneAbstraite zone, Coordonnee position)
        {
            idGenerator++;
            Coordonnee posNoReference = new Coordonnee(position.X, position.Y);
            int PV = (ConfigurationManager.AppSettings["PointDeVie"] != null) ? Convert.ToInt32(ConfigurationManager.AppSettings["PointDeVie"]) : 100;
            Reine fourmi = new Reine.ReineBuilder().
                         BuildEtat(CollectionEtat.EtatOeuf).
                         BuildId(idGenerator).
                         BuildNom("Reine " + idGenerator).
                         BuildPointVie(PV).
                         BuildZone(zone).
                         BuildPosition(posNoReference).
                         Build();
            return fourmi;
        }
    }
}
