namespace CLNavigateur
{
    public class Navigateur : IObservateur
    {

        public void Actualiser(Satellite _satellite)
        {
            Console.WriteLine($"La position du satellite est {_satellite.Position} avec une précision {_satellite.Precision}");
        }

    }
}