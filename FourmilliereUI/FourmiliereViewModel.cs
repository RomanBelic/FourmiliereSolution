using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;
using LibMetier;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading;

namespace FourmilliereUI
{
    public class FourmiliereViewModel: ViewModelBase
    {
        private SimulateurFourmi simulateur;
        private Fourmi reine;
        private Fourmi fourmi;
        public ObservableCollection<Fourmi> fourmiList = new ObservableCollection<Fourmi>();

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
