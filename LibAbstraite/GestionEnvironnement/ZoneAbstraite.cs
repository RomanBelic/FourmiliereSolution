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

        private List<ObjetAbstrait> listObjets;
        public List<ObjetAbstrait> ListObjets { get => listObjets; set => listObjets = value; }
       
        private int limitX;
        public int LimitX { get => limitX; set => limitX = value; }

        private int limitY;
        public int LimitY { get => limitY; set => limitY = value; }

        public ZoneAbstraite(int limitX, int limitY, string nom)
        {
            this.LimitX = limitX;
            this.limitY = limitY;
            this.nom = nom;
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
    }

    public class ZoneEmpty : ZoneAbstraite
    {
        public ZoneEmpty() : base(0, 0, string.Empty)
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