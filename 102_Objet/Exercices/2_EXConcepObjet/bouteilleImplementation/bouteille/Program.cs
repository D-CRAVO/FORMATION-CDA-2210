using bouteille;

Bouteille bouteilleChampagne  = new Bouteille(100, "Champagne", "verre", true, 100);
Bouteille bouteilleEau = new Bouteille(75,"Eau", "plastique", true, 75);

bouteilleEau.Ouvrir();
Console.WriteLine(bouteilleEau.Remplir(25));
bouteilleEau.Fermer();
Console.WriteLine (bouteilleEau.Vider(85));
Console.WriteLine (bouteilleEau.ViderCompletement());
bouteilleEau.ChangerContenu("Coca-Cola");
Console.WriteLine(bouteilleEau);
Console.WriteLine(bouteilleEau.Recycler());
Console.WriteLine(bouteilleChampagne.Recycler());