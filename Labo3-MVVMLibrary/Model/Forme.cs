﻿namespace Labo3_MVVMLibrary.Model
{
    public abstract class Forme : IForme
    {
        protected ICoordonnees pointAccroche;

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
