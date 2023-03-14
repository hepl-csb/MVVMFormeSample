namespace Infrastructure;

public interface IRectangle : IForme
{
    int Longueur { get; set; }
    int Largeur { get; set; }
}