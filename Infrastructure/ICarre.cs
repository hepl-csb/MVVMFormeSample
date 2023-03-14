namespace Infrastructure;

public interface ICarre : IForme
{
    int Longueur { get; set; }

    string Couleur { get; set; }
}