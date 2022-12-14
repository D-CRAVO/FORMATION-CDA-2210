/// <summary>
/// Classe Jante de la roue
/// </summary>
public class Jante
{
    /// <summary>
    /// Déclaration des attributs
    /// </summary>
    public string matiere { get; private set; }
    public string couleur { get; private set; }
    public uint rayonEnPouces { get; private set; }


    /// <summary>
    /// Constructeur à vide
    /// </summary>
    public Jante()
    {
        matiere = "aluminium";
        couleur = "gris";
        rayonEnPouces = 15;
    }


    /// <summary>
    /// Constructeur classique
    /// </summary>
    /// <param name="_matiere">Matière de la jante</param>
    /// <param name="_couleur">Couleur de la jante</param>
    /// <param name="_rayonEnPouces">Rayon en Pouces de la jante</param>
    public Jante(string _matiere, string _couleur, uint _rayonEnPouces)
    {
        matiere = _matiere;
        couleur = _couleur;
        rayonEnPouces = _rayonEnPouces;
    }


    /// <summary>
    /// Peindre les jantes
    /// </summary>
    /// <param name="_nouvelleCouleur">Nouvelle couleur de la jante</param>
    public void Peindre(string _nouvelleCouleur) 
    {
        couleur = _nouvelleCouleur;
    }
}