/// <summary>
/// Classe Moteur
/// </summary>
public class Moteur
{
    /// <summary>
    /// Type de carburant du moteur
    /// </summary>
    private string carburant;
    /// <summary>
    /// Cylindrée du moteur
    /// </summary>
    private double cylindree;
    /// <summary>
    /// Puissance du moteur
    /// </summary>
    private uint puissance;
    /// <summary>
    /// Indique si le moteur tourne
    /// </summary>
    public bool moteurTourne { get; private set; }

    //public int vari {  get; private set; }

    /// <summary>
    /// Accesseurs à l'attribut "moteurTourne"
    /// </summary>
    //public bool MoteurTourne
    //{
    //    get { return moteurTourne; }
    //}


    /// <summary>
    /// Constructeur à vide
    /// </summary>
    public Moteur()
    {
        carburant = "gazole";
        cylindree = 1.9;
        puissance = 100;
        moteurTourne = false;
    }


    /// <summary>
    /// Constructeur classique
    /// </summary>
    /// <param name="_carburant">Type de carburant du moteur</param>
    /// <param name="_cylindree">Cylindrée du moteur</param>
    /// <param name="_puissance">Puissance du moteur</param>
    /// <param name="_moteurTourne">Indique si le moteur tourne</param>
    public Moteur(string _carburant, double _cylindree, uint _puissance, bool _moteurTourne)
    {
        carburant = _carburant;
        cylindree = _cylindree;
        puissance = _puissance;
        moteurTourne = _moteurTourne;
    }


    /// <summary>
    /// Constructeur de clonage avec interdépendance
    /// </summary>
    /// <param name="_moteurCopie"></param>
    public Moteur(Moteur _moteurCopie) 
        : this
        (
        _moteurCopie.carburant,
        _moteurCopie.cylindree,
        _moteurCopie.puissance,
        _moteurCopie.moteurTourne
        )
    { }


    /// <summary>
    /// Démarrer le moteur
    /// </summary>
    /// <returns>
    /// "true" si le moteur démarre
    /// "false" dans le cas contraire
    /// </returns>
    public bool Demarrer()
    {
        if (!moteurTourne)
        {
            moteurTourne = true;
            return true;
        }
        return false;
    }


    /// <summary>
    /// Arrêter le moteur
    /// </summary>
    /// <returns>
    /// "true" si le moteur s'arrête
    /// "false" dans le cas contraire
    /// </returns>
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