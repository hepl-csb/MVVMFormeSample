using System.Collections.Generic;

namespace Labo3_MoreSimple.Model
{
    public class FormeAbscisseComparer :IComparer<Forme>
    {
        public int Compare(Forme? forme1, Forme? forme2)
        {
            return forme1.PointAccroche.X - forme2.PointAccroche.X;
        }
    }
}
