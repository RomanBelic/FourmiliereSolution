using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetier
{
    public class Nourriture : ObjetAbstrait
    {
        public int nourrX { get; set; }
        public int nourrY { get; set; }
        public Nourriture(int Id) : base(Id, "Nourriture")
        {
        }

        public Nourriture(int x, int y)
        {
            this.nourrX = x;
            this.nourrY = y;
        }

        protected override object KeyComparer => Id;
    }
}
