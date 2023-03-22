using Infrastructure;
using Model;

namespace ViewModel.Formes
{
    public class CarreWrapper : FormeWrapper<Carre>, ICarre
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

        public string Couleur
        {
            get => Content.Couleur;
            set
            {
                if (value == Content.Couleur) return;
                Content.Couleur = value;
                OnPropertyChanged();
            }
        }

        public string Course
        {
            get => Content.Course;
            set
            {
                if (value == Content.Course) return;
                Content.Course = value;
                OnPropertyChanged();
            }
        }

        public override double Area => Longueur*Longueur;
    }
}
