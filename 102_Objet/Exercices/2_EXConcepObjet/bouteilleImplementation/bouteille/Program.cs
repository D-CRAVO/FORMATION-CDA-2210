using bouteille;

Bouteille bouteilleChampagne = new Bouteille(100, "Champagne", "verre", true, 100);
Bouteille bouteilleEau = new Bouteille(75, "Eau", "plastique", true, 75);

try
{
    bool resultat01 = bouteilleEau.Ouvrir();
    bool resultat02 = bouteilleEau.Remplir(25);
    bool resultat03 = bouteilleEau.Fermer();
    bool resultat04 = bouteilleEau.Ouvrir();
    bool resultat05 = bouteilleEau.Ouvrir();
    bool resultat06 = bouteilleEau.Vider(85);
    bool resultat07 = bouteilleEau.ViderCompletement();
    bool resultat08 = bouteilleEau.ChangerContenu("Coca-Cola");
    string resultat09 = bouteilleEau.Recycler();
    string resultat10 = bouteilleChampagne.Recycler();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

