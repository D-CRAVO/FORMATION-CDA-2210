public class Voiture
{
    /**
     * Déclaration des attributs
     */
    private string marque;
    private string modele;
    private double vitesseKmh;
    private double vMaxKmh;
    private Moteur moteur;
    private Roue roue;


    public Moteur Moteur { get { return moteur; } set { moteur = value; } }


    /**
     * Constructeur à vide
     */
    public Voiture()
    {
        marque = "Seat";
        modele = "Cordoba";
        vitesseKmh = 0;
        vMaxKmh = 170;
        moteur = new Moteur();
        roue = new Roue();
    }

 
    /**
     * Constructeur classique
     */
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


    /**
     * Faire accélérer la voiture
     */
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


    /**
     * Faire ralentir la voiture
     */
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