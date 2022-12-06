public class Pneu
{
    /**
     * Déclaration des attributs
     */
    private uint largeur;
    private uint hauteur;
    private double presionEnBar;


    /**
     * Constructeur à vide
     */
    public Pneu()
    {
        largeur = 205;
        hauteur = 55;
        presionEnBar = 1.9;
    }


    /**
     * Constructeur classique
     */
    public Pneu(uint _largeur, uint _hauteur, double _pression)
    {
        largeur = _largeur;
        hauteur = _hauteur;
        presionEnBar = _pression;
    }


    /**
     * Gonfler le pneu
     */
    public bool Gonfler(double _nouvellePression)
    {
        if (presionEnBar != _nouvellePression)
        {
            presionEnBar = _nouvellePression;
            return true;
        }
        return false;
    }
}