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
        private FabriqueFourmi fabrique = FabriqueFourmi.GetInstance();

        public ComportementReine(Fourmi fourmi) : base(fourmi)
        {
        }

        public override Fourmi CreerFourmi()
        {
            Coordonnee position = new Coordonnee(fourmi.Position.X, fourmi.Position.Y);
            Fourmi spawn = fabrique.Creer(fourmi.Zone, position);
            spawn.Comportement = new ComportementFourmi(spawn);
            return spawn;
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
    }
}
