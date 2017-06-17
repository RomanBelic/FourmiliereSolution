using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourmilliereUI
{
    public class FourmiliereViewModel: ViewModelBase
    {
        public string titre;
        public string Titre
        {
            get { return titre; }
            set
            {
                titre = value;
                OnPropertyChanged("titre");
            }
        }
        public FourmiliereViewModel()
        {
            this.titre = "fourmilière";

        }
    }
}
