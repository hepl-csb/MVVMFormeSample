using Infrastructure;
using Model;

namespace ViewModel.Formes
{
    public class CercleWrapper : FormeWrapper<Cercle>, ICercle
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
