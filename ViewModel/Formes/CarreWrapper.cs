using Infrastructure;
using Model;

namespace ViewModel.Formes
{
    public class CarreWrapper : FormeWrapper<Carre>, ICarre
    {
        private string _couleur;

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

        public string Couleur
        {
            get => _couleur;
            set
            {
                if (value == Content.Couleur) return;
                Content.Couleur = value;
                OnPropertyChanged();
            }
        }

        public override double Area => Math.Sqrt(Longueur);
    }
}
