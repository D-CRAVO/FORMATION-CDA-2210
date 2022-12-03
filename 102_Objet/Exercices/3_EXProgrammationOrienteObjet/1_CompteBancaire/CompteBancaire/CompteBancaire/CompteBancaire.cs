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

        /**
         * Déclaration des propriétés
         */
        private string numero { get; }
        private string proprietaire { get; set; }
        private float solde { get; set; }
        private int decouvert { get; set; }


        /**
         * Déclaration des méthodes
         */


        /**
         * Constructeur à vide
         */
        public CompteBancaire()
        {
            this.numero = numeroIncremente.ToString();
            numeroIncremente++;
            this.proprietaire = "sansNom";
            this.solde = 0;
            this.decouvert = 0;
        }


        /**
         * Constructeur
         */
        public CompteBancaire(string _proprietaire, float _solde, int _decouvert)
        {
            this.numero = numeroIncremente.ToString();
            numeroIncremente++;
            this.proprietaire = _proprietaire;
            this.solde = _solde;
            if (_decouvert <= 0)
            {
                this.decouvert = _decouvert;
            }
        }


        /**
         * Affiche toutes les informations du compte bancaire.
         */
        public override string ToString()
        {
            return $"Le compte  {this.numero}  a pour propriétaire {this.proprietaire}, pour solde {this.solde} euros, et pour découvert autorisé {this.decouvert} euros";
        }


        /**
         * Crédite le compte "this" du montant "_montant"
         */
        public void Crediter(float _montantCredit)
        {
            if (_montantCredit <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_montantCredit), "Le montant du crédit doit être positif");
            }
            this.solde += _montantCredit;
        }


        /**
         * Débite le compte "this" du montant "_montant"
         * et renvoie un booléen "verif" pour indiquer si l'opération a été effectuée.
         */
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


        /**
         * Tranfert le montant "_montant" du compte bancaire "this" vers le compte bancaire "_compteCredit"
         * Et renvoie un bool "verif" pour indiquer si l'opération a été effectuée.
         */
        public bool Transferer(CompteBancaire _compteCredit, float _montantTransfert)
        {
            this.Debiter(_montantTransfert);
            _compteCredit.Crediter(_montantTransfert);
            return true;
        }


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
