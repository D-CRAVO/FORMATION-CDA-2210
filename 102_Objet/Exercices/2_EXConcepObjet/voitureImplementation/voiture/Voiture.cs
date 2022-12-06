/// <summary>
/// Classe Voiture
/// </summary>
public class Voiture
{
    /// <summary>
    /// Marque de la voiture
    /// </summary>
    private string marque;
    /// <summary>
    /// Modèle de la voiture
    /// </summary>
    private string modele;
    /// <summary>
    /// Vitesse actuelle de la voiture en Kmh
    /// </summary>
    private double vitesseKmh;
    /// <summary>
    /// Vitesse maximale de la voiture en Kmh
    /// </summary>    
    private double vMaxKmh;
    /// <summary>
    /// Moteur de la voiture
    /// </summary>
    private Moteur moteur;
    /// <summary>
    /// Roue de la voiture
    /// </summary>
    private Roue roue;

    /// <summary>
    /// Accesseurs du moteur de la voiture
    /// </summary>
    public Moteur Moteur { get { return moteur; } set { moteur = value; } }


    /// <summary>
    /// Constructeur à vide
    /// </summary>
    public Voiture()
    {
        marque = "Seat";
        modele = "Cordoba";
        vitesseKmh = 0;
        vMaxKmh = 170;
        moteur = new Moteur();
        roue = new Roue();
    }


    /// <summary>
    /// Constructeur classique
    /// </summary>
    /// <param name="_marque">Marque de la voiture</param>
    /// <param name="_modele">Modèle de la voiture</param>
    /// <param name="_vitesseKmh">Vitesse actuelle de la voiture</param>
    /// <param name="_vMaxKmh">Vitesse maximale de la voiture</param>
    /// <param name="_carburant">Type de carburant du moteur</param>
    /// <param name="_cylindree">Cylindrée du moteur</param>
    /// <param name="_puissance">Puissance du moteur</param>
    /// <param name="_moteurTourne">Indique si le moteur tourne</param>
    /// <param name="_poidsEquilibrage">Poids d'équilibrage de la roue</param>
    /// <param name="_largeur">Largeur du pneu</param>
    /// <param name="_hauteur">Hauteur du pneu</param>
    /// <param name="_pression">Pression du pneu</param>
    /// <param name="_matiere">Matière de la jante</param>
    /// <param name="_couleur">Couleur de la jante</param>
    /// <param name="_rayonEnPouces">Rayon de la jante en Pouces</param>
    public Voiture(string _marque, string _modele, double _vitesseKmh, double _vMaxKmh,
        string _carburant, double _cylindree, uint _puissance, bool _moteurTourne,
        uint _poidsEquilibrage, 
        uint _largeur, uint _hauteur, float _pression, 
        string _matiere, string _couleur, uint _rayonEnPouces)
    {
        marque = _marque;
        modele = _modele;
        vitesseKmh = _vitesseKmh;
        vMaxKmh = _vMaxKmh;
        moteur = new Moteur(_carburant, _cylindree, _puissance, _moteurTourne);
        roue = new Roue(_poidsEquilibrage, _largeur, _hauteur, _pression, _matiere, _couleur, _rayonEnPouces);
    }


    /// <summary>
    /// Faire accélérer la voiture
    /// </summary>
    /// <returns>
    /// "true" si la voiture peut accélérer
    /// "false" dans le cas contraire
    /// </returns>
    public bool Accelerer() 
    {
        if (Moteur.MoteurTourne)
        {
            if (vitesseKmh < vMaxKmh - 10)
            {
                vitesseKmh += 10;
                return true;
            }
        }
        return false;
    }


    /// <summary>
    /// Faire ralentir la voiture
    /// </summary>
    /// <returns>
    /// "true" si la voiture peut ralentir
    /// "false dans le cas contraire
    /// </returns>
    public bool Ralentir() 
    {
        if (Moteur.MoteurTourne)
        {
            if (vitesseKmh > 10)
            {
                vitesseKmh -= 10;
                return true;
            }
        }
        return false;
    }
}