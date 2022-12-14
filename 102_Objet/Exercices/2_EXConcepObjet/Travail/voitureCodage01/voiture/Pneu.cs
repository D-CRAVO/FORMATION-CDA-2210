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
    public float presionEnBar { get; private set; }


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
    /// Modifie la pression du pneu
    /// </summary>
    /// <param name="_nouvellePression">Nouvelle pression du pneu</param>
    /// <returns>
    /// "true" si le pneu a pu être gonflé
    /// "false" dans le cas contraire
    /// </returns>
    public bool ModifierPression(float _nouvellePression)
    {
        if (presionEnBar != _nouvellePression)
        {
            presionEnBar = _nouvellePression;
            return true;
        }
        return false;
    }
}