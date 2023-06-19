namespace CLTransactions
{
    public class Transaction
    {
        private string nom;
        private DateOnly date;
        private float montant;
        private string codePostal;

        public string Nom { get { return nom; } set { nom = value; } }
        public DateOnly Date { get { return date; } set {  date = value; } }
        public float Montant { get {  return montant; } set {  montant = value; } }
        public string CodePostal { get {  return codePostal; } set {  codePostal = value; } }

        public Transaction(string nom,  DateOnly date, float montant, string codePostal)
        {
            this.nom = nom;
            this.date = date;
            this.montant = montant;
            this.codePostal = codePostal;
        }
    }
}