public class Moteur
{
    /**
     * Déclaration des attributs
     */
    private string carburant;
    private double cylindree;
    private uint puissance;
    private bool moteurTourne;


    /**
     * Constructeur à vide
     */
    public Moteur()
    {
        carburant = "gazole";
        cylindree = 1.9;
        puissance = 100;
        moteurTourne = false;
    }


    /**
    * Constructeur classique
    */
    public Moteur(string _carburant, double _cylindree, uint _puissance, bool _moteurTourne)
    {
        carburant = _carburant;
        cylindree = _cylindree;
        puissance = _puissance;
        moteurTourne = _moteurTourne;
    }


    /**
     * Constructeur de clonage avec interdépendance
     */
    public Moteur(Moteur _moteurCopie) 
        : this
        (
        _moteurCopie.carburant,
        _moteurCopie.cylindree,
        _moteurCopie.puissance,
        _moteurCopie.moteurTourne
        )
    { }


    /**
     * Démarrer le moteur
     */
    public bool Demarrer()
    {
        if (!moteurTourne)
        {
            moteurTourne = true;
            return true;
        }
        return false;
    }


    /**
     * Arrêter le moteur
     */
    public bool Arreter()
    {
        if (moteurTourne)
        {
            moteurTourne = false;
            return true;
        }
        return false;
    }
}