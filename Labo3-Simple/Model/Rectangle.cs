using System;

namespace Labo3_Simple.Model
{
    public class Rectangle :Forme, IEstDans, ISommets
    {
        public Rectangle() :this(new Coordonnees(0,0), 0,0) { }

        public Rectangle(int x, int y, int longueur, int largeur) : this(new Coordonnees(x, y), longueur, largeur)
        {

        }

        public Rectangle(Coordonnees coords, int longueur, int largeur)
        {
            this.pointAccroche = coords;
            this.Longueur = longueur;
            this.Largeur = largeur;
        }

        public int Longueur { get; set; }
        public int Largeur {get; set;}

        public override void Affiche()
        {
            Console.WriteLine($"Rectangle de longueur = {Longueur}, largeur = {Largeur} et point d'accroche {this.pointAccroche}\n");
        }
        public override string ToString()
        {
            return $"Rectangle({Longueur}, {Largeur}){this.pointAccroche}";
        }

        public bool CoordonneeEstDans(Coordonnees p)
        {
            return p.X >= this.pointAccroche.X && p.X <= this.pointAccroche.X + Longueur && p.Y >= this.pointAccroche.Y && p.Y <= this.pointAccroche.Y + Largeur;
            //return p.X >= _pointAccroche.X && p.X <= _pointAccroche.X + Longueur && p.Y <= _pointAccroche.Y && p.Y >= _pointAccroche.Y - largeur;
        }

        public int NbrSommets()
        {
            return 4;
        }
    }
}
