namespace CLEmprunts
{
    public class Emprunt
    {
        private string nom;
        private uint capital;
        private uint duree;
        private EnumPeriodicite periodicite;
        private float taux;

        public enum EnumPeriodicite
        {
            Mensuelle,
            Bimestrielle,
            Trimestrielle,
            Semestrielle,
            Annuelle
        }

        public Emprunt(string nom, uint capital, uint duree, EnumPeriodicite periodicite, float taux)
        {
            this.nom = nom;
            this.capital = capital;
            this.duree = duree;
            this.periodicite = periodicite;
            this.taux = taux;
        }
    }

    
}