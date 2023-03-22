using System;
using Labo3_MVVMLibrary.Model;

namespace Labo3_MVVMLibrary.ViewModel
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
