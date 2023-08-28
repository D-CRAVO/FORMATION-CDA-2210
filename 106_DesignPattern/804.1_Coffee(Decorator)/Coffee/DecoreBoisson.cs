namespace coffee
{
    public abstract class DecoreBoisson : Boisson
    {
        protected Boisson? boisson;

        public DecoreBoisson(Boisson boisson)
        {
            this.boisson = boisson;
        }
    }
}