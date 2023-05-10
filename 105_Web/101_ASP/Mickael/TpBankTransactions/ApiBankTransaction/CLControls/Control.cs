namespace CLControls
{
    public static class Control
    {
        public const string AccountNumber = @"^[1-9]{1}[0-9]{10}$";

        public static bool Amount(float amount) 
        { 
            if 
                (
                    amount > 0 
                    && amount <= 99000.00
                )
            {
                return true;
            }
            return false;
        }
    }
}