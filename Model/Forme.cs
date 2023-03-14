using Infrastructure;

namespace Model
{
    public abstract class Forme : IForme
    {
        protected Coordonnees pointAccroche;

        protected Forme()
        {
            pointAccroche = new Coordonnees();
        }

        public ICoordonnees PointAccroche
        {
            get => pointAccroche;
            set => pointAccroche = (Coordonnees)value;
        }

        public abstract void Affiche();

    }
}
