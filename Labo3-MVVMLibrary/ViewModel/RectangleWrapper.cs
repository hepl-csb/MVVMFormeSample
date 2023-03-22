using Labo3_MVVMLibrary.Model;

namespace Labo3_MVVMLibrary.ViewModel
{
    public class RectangleWrapper : FormeWrapper<Rectangle>
    {
        public RectangleWrapper(Rectangle content) : base(content)
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

        public int Largeur
        {
            get => Content.Largeur;
            set
            {
                if (value == Content.Largeur) return;
                Content.Largeur = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }


        public override double Area => Longueur * Largeur;
    }
}
