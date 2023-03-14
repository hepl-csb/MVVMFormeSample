using System;
using Labo3_Simple.Model;

namespace Labo3_Simple.ViewModel
{
    public class CarreWrapper : FormeWrapper<Carre>
    {
        public CarreWrapper(Carre carre) : base(carre)
        {
        }

        public int Longueur
        {
            get => Content.Longueur;
            set
            {
                if (value == Content.Longueur) return;
                Content.Longueur = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public override double Area => Math.Sqrt(Longueur);
    }
}
