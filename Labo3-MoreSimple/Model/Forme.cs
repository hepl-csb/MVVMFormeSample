namespace Labo3_MoreSimple.Model
{
    public abstract class Forme
    {
        protected Coordonnees pointAccroche;

        protected Forme()
        {
            pointAccroche = new Coordonnees();
        }

        public Coordonnees PointAccroche
        {
            get => pointAccroche;
            set => pointAccroche = value;
        }

        public abstract void Affiche();

    }
}
