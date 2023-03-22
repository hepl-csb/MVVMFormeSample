namespace Labo3_MVVMLibrary.Model
{
    public class MathUtil
    {
        public static int Surface(Carre carre) {return carre.Longueur * carre.Longueur;}

        public static int Surface(Cercle cercle) {return (int) (3.14159265359 * cercle.Rayon * cercle.Rayon);}

        public static int Surface(Rectangle rectangle) {return rectangle.Longueur * rectangle.Largeur;}

    }
}
