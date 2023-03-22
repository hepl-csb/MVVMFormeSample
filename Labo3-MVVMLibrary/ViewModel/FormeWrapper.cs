using Labo3_MVVMLibrary.Infrastructure;
using Labo3_MVVMLibrary.Model;

namespace Labo3_MVVMLibrary.ViewModel
{
    public abstract class FormeWrapper<T> : WrapperBase<T>, IForme where T : Forme
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
