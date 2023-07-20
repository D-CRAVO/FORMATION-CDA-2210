namespace CLNavigateur
{
    public class Navigateur : IObservateur
    {
        public Navigateur() { }

        void IObservateur.Actualiser(Satellite _satellite)
        {
            Affichage(_satellite);
        }

    }
}