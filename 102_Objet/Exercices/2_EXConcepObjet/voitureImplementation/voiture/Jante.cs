public class Jante
{
    /**
     * Déclaration des attributs
     */
    private string matiere;
    private string couleur;
    private uint rayonEnPouces;


    /**
     * Constructeur à vide
     */
    public Jante()
    {
        matiere = "aluminium";
        couleur = "gris";
        rayonEnPouces = 15;
    }


    /**
     * Constructeur classique
     */
    public Jante(string _matiere, string _couleur, uint _rayonEnPouces)
    {
        matiere = _matiere;
        couleur = _couleur;
        rayonEnPouces = _rayonEnPouces;
    }


    /**
     * Peindre les jantes
     */
    public void Peindre(string _nouvelleCouleur) 
    {
        couleur = _nouvelleCouleur;
    }
}