namespace LibAbstraite
{
    public abstract class AccesAbstrait
    {
        public ZoneAbstraite zdebut { get; set; }
        public ZoneAbstraite zfin { get; set; }

        public AccesAbstrait(ZoneAbstraite zdebut, ZoneAbstraite zfin)
        {
            this.zdebut = zdebut;
            this.zfin = zfin;
        }





    }
}