namespace LibAbstraite
{
    public abstract class ObjetAbstrait
    {
        public string Nom { get; set; }

        public ObjetAbstrait(string unNom)
        {
            this.Nom = unNom;
        }

    }
}