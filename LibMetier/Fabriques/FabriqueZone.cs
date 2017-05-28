using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace LibMetier
{
    public class FabriqueZone : FabriqueAbstraite<ZoneAbstraite>
    {
        private static FabriqueZone instance = new FabriqueZone();

        public static FabriqueZone GetInstance()
        {
            return instance;
        }

        private FabriqueZone()
        {

        }

        public override ZoneAbstraite Creer()
        {
            int limitX = ConfigurationManager.AppSettings["LimitZoneX"] != null ? Convert.ToInt32(ConfigurationManager.AppSettings["LimitZoneX"]) : 0;
            int limitY = ConfigurationManager.AppSettings["LimitZoneY"] != null ? Convert.ToInt32(ConfigurationManager.AppSettings["LimitZoneY"]) : 0;
            int uniteTaille = ConfigurationManager.AppSettings["UniteTaille"] != null ? Convert.ToInt32(ConfigurationManager.AppSettings["UniteTaille"]) : 0;
            return new ZoneFourmilliere(limitX, limitY, uniteTaille);
        }
    }
}
