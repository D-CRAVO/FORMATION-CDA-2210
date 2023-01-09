namespace LibraryCompte
{
    public class Compte
    {
        private static int numeroIncremente = 1;

        /// <summary>
        /// Numero de compte bancaire
        /// </summary>
        private uint numero { get; }
        /// <summary>
        /// Nom du propriétaire du compte
        /// </summary>
        private string proprietaire { get; set; }
        /// <summary>
        /// Solde du compte
        /// </summary>
        private float solde { get; set; }
        /// <summary>
        /// Montant du découvert autorisé
        /// </summary>
        private int decouvert { get; set; }





        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_proprietaire">Nom du propriétaire du compte</param>
        /// <param name="_solde">Solde du compte</param>
        /// <param name="_decouvert">Montant du découvert autorisé</param>
        public Compte(uint _numero, string _proprietaire, float _solde, int _decouvert)
        {
            numero = _numero;
            proprietaire = _proprietaire;
            solde = _solde;
            if (_decouvert <= 0)
            {
                decouvert = _decouvert;
            }
            else
            {
                throw new Exception("Le découvert doit être positif");
            }
        }


        /// <summary>
        /// Affiche toutes les informations du compte bancaire.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Le compte {numero} a pour propriétaire {proprietaire}, pour solde {solde} euros, et pour découvert autorisé {decouvert} euros";
        }


        /// <summary>
        /// Crédite le compte courant du montant passé en paramètre
        /// </summary>
        /// <param name="_montantCredit"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Crediter(float _montantCredit)
        {
            if (_montantCredit <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_montantCredit), "Le montant du crédit doit être positif");
            }
            this.solde += _montantCredit;
        }


        /// <summary>
        /// Débite le compte courant du montant passé en paramètre
        /// </summary>
        /// <param name="_montantDebit"></param>
        /// <returns>
        /// True si l'opération s'est bien déroulée
        /// False dans le cas contraire
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public bool Debiter(float _montantDebit)
        {
            if (_montantDebit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_montantDebit), "Le montant du débit doit être positif");
            }
            else if (this.solde - this.decouvert < _montantDebit)
            {
                return false;
            }
            this.solde -= _montantDebit;
            return true;
        }


        /// <summary>
        /// Tranfert le montant "_montant" du compte bancaire courant vers le compte bancaire passé en paramètre
        /// </summary>
        /// <param name="_compteCredit">Compte à crediter</param>
        /// <param name="_montantTransfert">Montant du transfert</param>
        /// <returns>
        /// True si l'opération s'est bien déroulée
        /// False dans le cas contraire
        /// </returns>
        public bool TransfererVers(Compte _compteCredit, float _montantTransfert)
        {
            if (this.Debiter(_montantTransfert))
            {
                _compteCredit.Crediter(_montantTransfert);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Permet de savoir si le solde du compte courant est supérieur ou inférieur au solde du compte passé en paramètre
        /// </summary>
        /// <param name="_compteComparaison"></param>
        /// <returns></returns>
        public string Comparer(Compte _compteComparaison)
        {
            if (solde < _compteComparaison.solde)
            {
                return $"Le solde du compte de {proprietaire} est inférieur au solde du compte de {_compteComparaison.proprietaire}";
            }
            return $"Le solde du compte de {proprietaire} est supérieur au solde du compte de {_compteComparaison.proprietaire}";
        }

        /// <summary>
        /// Indique si le solde du compte courant est supérieur au solde du compte passé en paramètre
        /// </summary>
        /// <param name="_compteComparaison"></param>
        /// <returns></returns>
        public bool SuperieurA(Compte _compteComparaison)
        {
            if (solde > _compteComparaison.solde)
            {
                return true;
            }
            return false;
        }
    }
}