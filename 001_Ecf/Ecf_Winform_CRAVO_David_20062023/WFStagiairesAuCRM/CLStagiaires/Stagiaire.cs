
namespace CLStagiaires
{
    public class Stagiaire
    {
        public enum EnumSection
        {
            ABCDEV = 0,
            DWWM = 1,
            CDA = 2
        }

        private string nom;
        private string prenom;
        private DateOnly dateDebut;
        private DateOnly dateFin;
        private EnumSection section;

        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public DateOnly DateDebut { get { return dateDebut; } set {dateDebut = value; } }
        public DateOnly DateFin { get { return dateFin; } set { dateFin = value; } }
        public EnumSection Section { get { return section; } set { section = value; } }

        public Stagiaire(string nom, string prenom, DateOnly dateDebut, DateOnly dateFin, EnumSection section)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.section = section;
        }
    }
}