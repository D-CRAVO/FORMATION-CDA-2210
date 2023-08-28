namespace coffee
{
    public class Cafe : Boisson
    {
        public Cafe()
        {
            description = "Café";
        }

        public override double GetPrix()
        {
            return 1.50;
        }
    }
}