using System;
using IEstDans = Labo3_Simple.Model.IEstDans;

namespace Labo3_Simple.Model
{
    public class Cercle : Forme, IEstDans
    {
        public Cercle() : this(new Coordonnees(0, 0), 0)
        {
        }

        public Cercle(int x, int y, int rayon) : this(new Coordonnees(x,y), rayon)
        {
        }

        public Cercle(Coordonnees coords, int rayon)
        {
            this.pointAccroche = coords;
            this.Rayon = rayon;
        }

        public int Rayon { get; set; }


        public override void Affiche()
        {
            Console.WriteLine($"Cercle de rayon {Rayon} accroché au point {this.pointAccroche}\n");
        }

        public override string ToString()
        {
            return $"Cercle({Rayon}){this.pointAccroche}";
        }

        public bool CoordonneeEstDans(Coordonnees p)
        {
            return (p.X-this.pointAccroche.X)*(p.X-this.pointAccroche.X) + (p.Y-this.pointAccroche.Y)*(p.Y-this.pointAccroche.Y) <= Rayon *Rayon ;
        }
    }
}