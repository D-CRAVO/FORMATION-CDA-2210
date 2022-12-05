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
    public Voiture(string _marque, string _modele, double _vitesseKmh, double _vMaxKmh, Moteur _moteur, Roue _roue)
    {
        marque = _marque;
        modele = _modele;
        vitesseKmh = _vitesseKmh;
        vMaxKmh = _vMaxKmh;
        moteur = _moteur;
        roue = _roue;
    }


    /**
     * Faire accélérer la voiture
     */
    public bool Accelerer() 
    {
        if (vitesseKmh < vMaxKmh - 10)
        {
            vitesseKmh += 10;
            return true;
        }
        return false;
    }


    /**
     * Faire ralentir la voiture
     */
    public bool Ralentir() 
    {
        if (vitesseKmh > 10)
        {
            vitesseKmh -= 10;
            return true;
        }
        return false;
    }
}