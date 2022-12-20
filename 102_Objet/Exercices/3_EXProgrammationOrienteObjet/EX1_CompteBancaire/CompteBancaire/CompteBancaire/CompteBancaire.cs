using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    internal class CompteBancaire
    {
        private static int numeroIncremente = 1;

        /// <summary>
        /// Numero de compte bancaire
        /// </summary>
        private string numero { get; }
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
        public CompteBancaire(string _proprietaire, float _solde, int _decouvert)
        {
            numero = numeroIncremente.ToString();
            numeroIncremente++;
            proprietaire = _proprietaire;
            solde = _solde;
            if (_decouvert <= 0)
            {
                decouvert = _decouvert;
            }
        }


        /// <summary>
        /// Constructeur à vide
        /// </summary>
        public CompteBancaire()
            : this("sansNom", 0, 0)
        { }



        /// <summary>
        /// Affiche toutes les informations du compte bancaire.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Le compte {this.numero} a pour propriétaire {this.proprietaire}, pour solde {this.solde} euros, et pour découvert autorisé {this.decouvert} euros";
        }


        /// <summary>
        /// Crédite le compte "this" du montant "_montant"
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
        /// Débite le compte "this" du montant "_montant"
        /// </summary>
        /// <param name="_montantDebit"></param>
        /// <returns>
        /// "true" si l'opération s'est bien déroulée
        /// "false" dans le cas contraire
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public bool Debiter(float _montantDebit)
        {
            if (_montantDebit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_montantDebit), "Le montant du débit doit être positif");
            }
            if (this.solde - this.decouvert < _montantDebit)
            {
                throw new InvalidOperationException("Le compte débiteur n'est pas assez provisionné");
            }
            this.solde -= _montantDebit;
            return true;
        }


        /// <summary>
        /// Tranfert le montant "_montant" du compte bancaire "this" vers le compte bancaire "_compteCredit"
        /// Et renvoie un bool "verif" pour indiquer si l'opération a été effectuée.
        /// </summary>
        /// <param name="_compteCredit">Compte à crediter</param>
        /// <param name="_montantTransfert">Montant du transfert</param>
        /// <returns>
        /// "true" si l'opération s'est bien déroulée
        /// "false" dans le cas contraire
        /// </returns>
        public bool TransfererVers(CompteBancaire _compteCredit, float _montantTransfert)
        {
            if (this.Debiter(_montantTransfert))
            {
                _compteCredit.Crediter(_montantTransfert);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Permet de savoir si le solde du compte "this" 
        /// est supérieur ou inférieur au solde du compte "_autreCompte"
        /// </summary>
        /// <param name="_autreCompte"></param>
        /// <returns></returns>
        public string Comparer(CompteBancaire _autreCompte)
        {
            if (solde < _autreCompte.solde)
            {
                return $"Le solde du compte de {proprietaire} est inférieur au solde du compte de {_autreCompte.proprietaire}";
            }
            return $"Le solde du compte de {proprietaire} est supérieur au solde du compte de {_autreCompte.proprietaire}";
        }

    }
}
