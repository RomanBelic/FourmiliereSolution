using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
    public class ComportementReine : ComportementFourmi
    {
        public ComportementReine(Fourmi fourmi) : base(fourmi)
        {
        }

        public override Fourmi CreerFourmi()
        {
            Fourmi nouvelleFourmi = new Fourmi();
            nouvelleFourmi.Etat.IdFlag = (int)EtatFlags.EtatOeuf;
            nouvelleFourmi.PointDeVie = 1;
            nouvelleFourmi.Comportement = new ComportementVide(nouvelleFourmi);

            return nouvelleFourmi;
        }

        public override void MangerObjet(ObjetAbstrait unObjet)
        {
            base.MangerObjet(unObjet);
        }

        public override void Nourrir(Fourmi fourmi)
        {
            
        }

        public override void Avancer()
        {
            base.Avancer();
        }

        public override void Mourir()
        {
            base.Mourir();
        }

        public override void ChoixZoneSuivante(ZoneAbstraite zone)
        {
            base.ChoixZoneSuivante(zone);
        }

        public override void Combattre(PersonnageAbstrait ennemi)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void Creuser(ZoneAbstraite uneZone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override void DeposerPheromone(ZoneAbstraite uneZone)
        {
            Console.WriteLine("Opération non autorisée");
        }

        public override 

    }
}
