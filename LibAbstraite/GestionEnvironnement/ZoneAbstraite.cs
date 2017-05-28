using System;
using System.Collections.Generic;

namespace LibAbstraite
{
    public abstract class ZoneAbstraite 
    {
        private string nom;
        public string Nom { get => nom; set => nom = value; }
 
        private List<PersonnageAbstrait> lstPersonnages;
        public List<PersonnageAbstrait> LstPersonnages { get => lstPersonnages; set => lstPersonnages = value; }

        private List<ObjetAbstrait> lstObjets;
        public List<ObjetAbstrait> LstObjets { get => lstObjets; set => lstObjets = value; }
       
        private int limitX;
        public int LimitX { get => limitX; set => limitX = value; }

        private int limitY;
        public int LimitY { get => limitY; set => limitY = value; }

        private int uniteTaille;
        public int UniteTaille { get => uniteTaille; set => uniteTaille = value; }

        public ZoneAbstraite(int limitX, int limitY, string nom, int uniteTaille)
        {
            this.limitX  = limitX;
            this.limitY = limitY;
            this.nom = nom;
            this.lstPersonnages = new List<PersonnageAbstrait>(64);
            this.lstObjets = new List<ObjetAbstrait>(64);
            this.uniteTaille = uniteTaille;
        }

        public ZoneAbstraite()
        {

        }

        public override string ToString()
        {
            return String.Format("{0}", nom);
        }

        public abstract void AjouterPersonnage(PersonnageAbstrait personnage);
        public abstract void SupprimerPersonnage(PersonnageAbstrait personnage);
    }

    public class Coordonnee
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Coordonnee(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override int GetHashCode()
        {
            return new { x, y }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj is Coordonnee) && this.x == ((Coordonnee)obj).x && this.y == ((Coordonnee)obj).y;
        }

        public override string ToString()
        {
            return String.Format("Position X : {0}, Y : {1}", x, y);
        }
    }

    public class ZoneEmpty : ZoneAbstraite
    {
        public ZoneEmpty() : base(0, 0, string.Empty, 0)
        {
        }

        public override void AjouterPersonnage(PersonnageAbstrait personnage)
        {
            Console.WriteLine("Operation Impossible");
        }

        public override void SupprimerPersonnage(PersonnageAbstrait personnage)
        {
            Console.WriteLine("Operation Impossible");
        }
    }
}