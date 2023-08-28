namespace coffee
{
    public abstract class Boisson
    {
        protected string description = "Boisson inconnue";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double GetPrix();
    }
}