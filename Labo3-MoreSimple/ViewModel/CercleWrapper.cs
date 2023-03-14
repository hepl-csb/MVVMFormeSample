using System;
using Labo3_MoreSimple.Model;

namespace Labo3_MoreSimple.ViewModel
{
    public class CercleWrapper : FormeWrapper
    {
        private Cercle CercleContent => (Cercle) Content;
        public CercleWrapper(Cercle cercle) : base(cercle)
        {
        }

        public int Rayon
        {
            get => CercleContent.Rayon;
            set
            {
                if (value == CercleContent.Rayon) return;
                CercleContent.Rayon = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public override double Area => Math.PI * Rayon * Rayon;
    }
}
