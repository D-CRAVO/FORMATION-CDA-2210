public class Roue
{
    /**
     * Déclaration des attributs
     */
    private uint poidsEquilibrageGrammes;
    private Pneu pneu;
    private Jante jante;


    /**
     * Constructeur à vide
     */
    public Roue()
    {
        poidsEquilibrageGrammes = 0;
        pneu = new Pneu();
        jante = new Jante();
    }


    /**
     * Constructeur classique
     */
    public Roue(uint _poidsEquilibrage, Pneu _pneu, Jante _jante)
    {
        poidsEquilibrageGrammes = _poidsEquilibrage;
        _pneu = new Pneu();
        _jante = new Jante();
    }


    public void Equilibrer(uint _nouveauPoids) 
    {
        poidsEquilibrageGrammes = _nouveauPoids;
    }
}