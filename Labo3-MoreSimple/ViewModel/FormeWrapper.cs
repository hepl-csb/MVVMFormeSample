using Labo3_MoreSimple.Infrastructure;
using Labo3_MoreSimple.Model;

namespace Labo3_MoreSimple.ViewModel
{
    public abstract class FormeWrapper : WrapperBase
    {
        private Forme ContentForme => (Forme)Content;
        public CoordonneesWrapper PointAccroche { get; set; }

        protected FormeWrapper(object content) : base(content)
        {
            PointAccroche= new CoordonneesWrapper(ContentForme.PointAccroche);
        }

        public abstract double Area { get; }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
