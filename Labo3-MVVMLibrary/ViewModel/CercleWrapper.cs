using System;
using Labo3_MVVMLibrary.Model;

namespace Labo3_MVVMLibrary.ViewModel
{
    public class CercleWrapper : FormeWrapper<Cercle>
    {
        public CercleWrapper(Cercle cercle) : base(cercle)
        {
        }

        public int Rayon
        {
            get => Content.Rayon;
            set
            {
                if (value == Content.Rayon) return;
                Content.Rayon = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public override double Area => Math.PI * Math.Sqrt(Rayon);
    }
}
