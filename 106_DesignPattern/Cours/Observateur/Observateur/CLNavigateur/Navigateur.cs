namespace CLNavigateur
{
    public class Navigateur : IObservateur
    {

        public void Actualiser(Satellite _satellite)
        {
            Console.WriteLine($"Votre position est {_satellite.Position} avec une précision {_satellite.Precision}");
        }

    }
}