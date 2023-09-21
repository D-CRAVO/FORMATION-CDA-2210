using CLBouteille.ExceptionsBouteille;
using CLBouteille;

try
{
    Bouteille bouteille = new Bouteille(1, 2, true);
}
catch (ExceptionValeurContenuIncorrecte e)
{
    Console.WriteLine(e.Message);
}
