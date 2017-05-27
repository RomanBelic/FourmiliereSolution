namespace LibAbstraite
{
    public abstract class ObjetAbstrait
    {
        protected abstract object KeyComparer { get; }

        private int id;
        public int Id { get => id; set => id = value; }

        private string nomStr;
        public string NomStr { get => nomStr; set => nomStr = value; }

        private Coordonnee positionObjet;
        public Coordonnee PositionObjet { get => positionObjet; set => positionObjet = value; }

        public ObjetAbstrait (int Id, string NomStr) {
            this.id = Id;
            this.nomStr = NomStr;
            this.positionObjet = new Coordonnee(0, 0);
        }

        public ObjetAbstrait()
        {

        }

        public override int GetHashCode()           // Si Equals retourne true, GetHashCode retourne true et sert à comparer les objets via ==
        {
            return new { KeyComparer, nomStr }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is ObjetAbstrait && this.KeyComparer.Equals(((ObjetAbstrait)obj).KeyComparer);
        }
    }
}