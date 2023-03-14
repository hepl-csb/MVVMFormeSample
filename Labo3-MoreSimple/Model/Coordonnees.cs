namespace Labo3_MoreSimple.Model
{
    public class Coordonnees 
    {
        public Coordonnees() : this(0, 0) {}

        public Coordonnees(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $"X:{X}-Y:{Y})";
        }
    }
}
