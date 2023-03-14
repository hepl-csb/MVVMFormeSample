using Labo3_MoreSimple.Infrastructure;
using Labo3_MoreSimple.Model;

namespace Labo3_MoreSimple.ViewModel
{
    public class CoordonneesWrapper : WrapperBase
    {
        private Coordonnees CoordoneesContent => (Coordonnees) Content;
        public CoordonneesWrapper(Coordonnees content) : base(content)
        {
        }

        public int X
        {
            get => CoordoneesContent.X;
            set
            {
                if (CoordoneesContent.X == value)
                    return;
                CoordoneesContent.X = value;
                OnPropertyChanged();
            }
        }

        public int Y
        {
            get => CoordoneesContent.Y;
            set
            {
                if (value == CoordoneesContent.Y) return;
                CoordoneesContent.Y = value;
                OnPropertyChanged();
            }
        }

    }
}
