// Déclaration des variables

int position = 2;
string valeurRenseignee;
int N;
string resultat = "0\n1";
uint nbPrecedent = 0;
uint nbCourant = 1;
uint nbSuivant;


// Début du programme


do
{
    Console.WriteLine("Combien de nombres de la suite de Fibonacci souhaitez-vous afficher ? : ");
    valeurRenseignee = Console.ReadLine();
    if (valeurRenseignee != "")
    {
        N = int.Parse(valeurRenseignee);
        if (N > 2)
        {
            while (position < N)
            {
                nbSuivant = (nbPrecedent + nbCourant);
                resultat = resultat + "\n" + nbSuivant;
                nbPrecedent = nbCourant;
                nbCourant = nbSuivant;
                position++;
            }
        }
        else
        {
            N = 2;
        }
        Console.WriteLine("Les " + N + " premiers nombres de la suite de Fibonacci sont :");
        Console.WriteLine(resultat);
    }
    
    
} while (valeurRenseignee != "");
Console.WriteLine("Programme terminé !");