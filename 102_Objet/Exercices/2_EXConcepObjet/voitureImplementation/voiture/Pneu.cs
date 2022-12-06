/// <summary>
/// Classe Pneu de la roue
/// </summary>
public class Pneu
{
    /// <summary>
    /// Largeur du pneu
    /// </summary>
    public uint largeur;
    /// <summary>
    /// Hauteur du pneu
    /// </summary>
    public uint hauteur;
    /// <summary>
    /// Pression en bar dans le pneu
    /// </summary>
    private float presionEnBar;


    /// <summary>
    /// Constructeur à vide
    /// </summary>
    public Pneu()
    {
        largeur = 205;
        hauteur = 55;
        presionEnBar = 1.9f;
    }


    /// <summary>
    /// Constructeur classique
    /// </summary>
    /// <param name="_largeur">Largeur du pneu</param>
    /// <param name="_hauteur">Hauteur du pneu</param>
    /// <param name="_pression">Pression en Bar du pneu</param>
    public Pneu(uint _largeur, uint _hauteur, float _pression)
    {
        largeur = _largeur;
        hauteur = _hauteur;
        presionEnBar = _pression;
    }


    /// <summary>
    /// Gonfler le pneu
    /// </summary>
    /// <param name="_nouvellePression">Nouvelle pression du pneu</param>
    /// <returns>
    /// "true" si le pneu a pu être gonflé
    /// "false" dans le cas contraire
    /// </returns>
    public bool Gonfler(float _nouvellePression)
    {
        if (presionEnBar != _nouvellePression)
        {
            presionEnBar = _nouvellePression;
            return true;
        }
        return false;
    }
}