namespace coffee
{
    public class Lait : DecoreBoisson
    {
        public Lait(Boisson boisson) : base (boisson){}

        public override string GetDescription()
        {
            return boisson.GetDescription() + ", Lait";
        }
        public override double GetPrix()
        {
            return 0.5 + boisson.GetPrix();
        }
    }
}