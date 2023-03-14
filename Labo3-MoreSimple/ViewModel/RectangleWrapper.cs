using Labo3_MoreSimple.Infrastructure;
using Labo3_MoreSimple.Model;

namespace Labo3_MoreSimple.ViewModel
{
    public class RectangleWrapper : FormeWrapper
    {
        private Rectangle RectangleContent => (Rectangle)Content;
        public RectangleWrapper(Rectangle content) : base(content)
        {
        }

        public int Longueur
        {
            get => RectangleContent.Longueur;
            set
            {
                if (value == RectangleContent.Longueur) return;
                RectangleContent.Longueur = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public int Largeur
        {
            get => RectangleContent.Largeur;
            set
            {
                if (value == RectangleContent.Largeur) return;
                RectangleContent.Largeur = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }


        public override double Area => Longueur * Largeur;
    }
}
