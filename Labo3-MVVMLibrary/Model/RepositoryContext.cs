using System.Collections.Generic;
using System.Linq;

namespace Labo3_MVVMLibrary.Model
{
    public class RepositoryContext
    {
        public List<IForme> Formes { get; set; }

        public RepositoryContext()
        {
            Formes = new List<IForme>();
        }

        public void AddForme(Forme forme)
        {
            Formes.Add(forme);
        }

        public IEnumerable<Carre> GetCarre()
        {
            return Get<Carre>();
        }
        public IEnumerable<Cercle> GetCercle()
        {
            return Get<Cercle>();
        }
        public IEnumerable<Rectangle> GetRectangle()
        {
            return Get<Rectangle>();
        }
        public IEnumerable<T> Get<T>()
        {
            return Formes.Where(i => i.GetType() == typeof(T)).Cast<T>().ToList();
        }

    }
}
