using System;
using IEstDans = Labo3_Simple.Model.IEstDans;
using ISommets = Labo3_Simple.Model.ISommets;

namespace Labo3_Simple.Model
{
    public class Carre : Forme, IEstDans, ISommets, IComparable
    {
        public int Longueur { get; set; }

        public Carre() : this(new Coordonnees(0, 0), 0)
        {
        }

        public Carre(int x, int y, int longueur) : this(new Coordonnees(x, y), longueur)
        {

        }

        public Carre(Coordonnees coords, int longueur)
        {
            this.pointAccroche = coords;
            this.Longueur = longueur;
        }
 
        public override string ToString()
        {
            return $"Carré({Longueur})" + pointAccroche;
        }

        public override void Affiche()
        {
            Console.WriteLine($"Carré de longueur {Longueur} accroché au point {this.pointAccroche}\n");
        }

        public bool CoordonneeEstDans(Coordonnees p)
        {
            return p.X >= this.pointAccroche.X && p.X <= this.pointAccroche.X + Longueur && p.Y >= this.pointAccroche.Y && p.Y <= this.pointAccroche.Y + Longueur;
            //return p.X >= _pointAccroche.X && p.X <= _pointAccroche.X + longueur && p.Y <= _pointAccroche.Y && p.Y >= _pointAccroche.Y - longueur;
        }

        public int NbrSommets()
        {
            return 4;
        }

        public int CompareTo(object? carre)
        {
            return CompareLong(this, (Carre)carre);
        }

        public static int CompareLong(Carre carre1, Carre carre2)
        {
            return MathUtil.Surface(carre1) - MathUtil.Surface(carre2);
        }
    }
}
