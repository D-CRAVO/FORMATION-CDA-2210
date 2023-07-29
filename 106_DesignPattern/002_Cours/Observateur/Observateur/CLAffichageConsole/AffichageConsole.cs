using CLNavigateur;
using CLObservateur;

namespace CLAffichageConsole
{
    public class AffichageConsole : IAffichage
    {
        void IAffichage.Affichage(Satellite _satellite)
        {
            Console.WriteLine($"Votre position est {_satellite.Position} avec une précision {_satellite.Precision}");
        }
    }
}