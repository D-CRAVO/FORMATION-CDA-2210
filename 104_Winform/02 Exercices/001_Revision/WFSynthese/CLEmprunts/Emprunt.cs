namespace CLEmprunts
{
    public class Emprunt
    {
        private string? nom;
        private uint capital;
        private uint duree;
        private EnumPeriodicite periodicite;
        private float tauxAnnuel;

        public string? Nom { get { return nom; } set { nom = value; } }
        public uint Capital { get { return capital; } set { capital = value; } }
        public uint Duree { get { return duree; } set { duree = value; } }
        public EnumPeriodicite Periodicite { get { return periodicite; } set { periodicite = value; } }
        public float TauxAnnuel { get { return tauxAnnuel; } set { tauxAnnuel = value; } }
        
        public enum EnumPeriodicite
        {
            Mensuelle = 1,
            Bimestrielle = 2,
            Trimestrielle = 3,
            Semestrielle = 6,
            Annuelle = 12
        }

        public Emprunt(string? nom, uint capital, uint duree, EnumPeriodicite periodicite, float taux)
        {
            this.nom = nom;
            this.capital = capital;
            this.duree = duree;
            this.periodicite = periodicite;
            this.tauxAnnuel = taux;
        }

        public Emprunt() : this(string.Empty, 1, 1, EnumPeriodicite.Mensuelle, 0.07f) { }

        public Emprunt(Emprunt _emprunt) : this 
            (
                _emprunt.nom,
                _emprunt.capital,
                _emprunt.duree,
                _emprunt.periodicite,
                _emprunt.tauxAnnuel
            )
        { }


        public static uint CalculNbRemboursements(Emprunt _emprunt)
        {
            return _emprunt.duree / (uint)_emprunt.periodicite;
        }
    }

    
}