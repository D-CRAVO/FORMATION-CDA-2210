namespace CLValidationSaisie
{
    public class Transaction
    {
        private string nom;
        private DateOnly date;
        private float montant;
        private string cp;

        public string Nom { get { return nom; } }
        public DateOnly Date { get { return date; } }
        public float Montant { get { return montant; } }
        public string Cp { get { return cp; } }

        public Transaction(string _nom, DateOnly _date, float _montant, string _cp)
        {
            this.nom = _nom;
            this.date = _date;
            this.montant = _montant;
            this.cp = _cp;
        }
    }
}