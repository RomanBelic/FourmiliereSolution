using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourmilliereUI
{
    public class FourmiliereViewModel
    {
        public string titre;
        public int DimensionX { get; set; }
        public int DimensionY { get; set; }
        public FourmiliereViewModel()
        {
            this.titre = "fourmilière";
            this.DimensionX = 10;
            this.DimensionY = 10;
        }
    }
}
