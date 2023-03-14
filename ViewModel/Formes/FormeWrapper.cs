using Infrastructure;
using Model;

namespace ViewModel.Formes
{
    public abstract class FormeWrapper<T> : WrapperBase<T>, IForme, IAreaProvider where T : Forme
    {
        protected FormeWrapper(T content) : base(content)
        {
            PointAccroche= new CoordonneesWrapper((Coordonnees) Content.PointAccroche);
        }

        public ICoordonnees PointAccroche { get; set; }

        public abstract double Area { get; }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
