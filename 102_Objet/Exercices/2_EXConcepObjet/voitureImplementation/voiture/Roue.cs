/// <summary>
/// Classe Roue
/// </summary>
public class Roue
{
    /// <summary>
    /// Poids d'équilibrage de la jante en Grammes
    /// </summary>
    private uint poidsEquilibrageGrammes;
    /// <summary>
    /// Pneu de la roue
    /// </summary>
    private Pneu pneu;
    /// <summary>
    /// Jante de la roue
    /// </summary>
    private Jante jante;


    /// <summary>
    /// Constructeur à vide
    /// </summary>
    public Roue()
    {
        poidsEquilibrageGrammes = 0;
        pneu = new Pneu();
        jante = new Jante();
    }


    /// <summary>
    /// Constructeur classique
    /// </summary>
    /// <param name="_poidsEquilibrage">Poids d'équilibrage de la roue en Grammes</param>
    /// <param name="_largeur">Largeur du pneu</param>
    /// <param name="_hauteur">Hauteur du pneu</param>
    /// <param name="_pression">Pression en Bar du pneu</param>
    /// <param name="_matiere">Matière de la jante</param>
    /// <param name="_couleur">Couleur de la jante</param>
    /// <param name="_rayon">Rayon en Pouces de la jante</param>
    public Roue(uint _poidsEquilibrage, uint _largeur, uint _hauteur, float _pression, string _matiere, string _couleur, uint _rayon)
    {
        poidsEquilibrageGrammes = _poidsEquilibrage;
        pneu = new Pneu(_largeur, _hauteur, _pression);
        jante = new Jante(_matiere, _couleur, _rayon);
    }

    /// <summary>
    /// Equilibrer la jante
    /// </summary>
    /// <param name="_nouveauPoids">Nouveau poids installé pour équilibrer la roue</param>
    public void Equilibrer(uint _nouveauPoids) 
    {
        poidsEquilibrageGrammes = _nouveauPoids;
    }
}