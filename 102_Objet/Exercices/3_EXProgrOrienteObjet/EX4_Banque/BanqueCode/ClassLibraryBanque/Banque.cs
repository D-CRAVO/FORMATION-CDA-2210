using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibraryBanque;

namespace ClassLibraryBanque
{
    public class Banque
    {
        /// <summary>
        /// Liste des comptes de la banque
        /// </summary>
        private List<Compte> mesComptes;
        /// <summary>
        /// Nom de la banque
        /// </summary>
        private string nom;
        /// <summary>
        /// Ville de la banque
        /// </summary>
        private string ville;

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_nom">Nom de la banque</param>
        /// <param name="_ville">Ville de la banque</param>
        public Banque(string _nom, string _ville) 
        {
            mesComptes = new List<Compte>();

            nom = _nom;
            ville = _ville;
     
        }

        /// <summary>
        /// Réécriture de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string resultBanque = $"La banque {nom} de la ville de {ville} possède les comptes :\n";
            string resultCompte = "";
            for(int i = 0; i < mesComptes.Count; i++) 
            {
                resultCompte += mesComptes[i].ToString() + "\n";
            }
            return resultBanque + resultCompte;
        }

        /// <summary>
        /// Ajoute un compte à la liste de comptes
        /// </summary>
        /// <param name="_compte"></param>
        private void AjouteCompte(Compte _compte)
        {
            mesComptes.Add(_compte);
        }

        /// <summary>
        /// Crée et ajoute un compte à la liste des comptes
        /// </summary>
        /// <param name="_numero">Numero du compte</param>
        /// <param name="_nom">Nom du propriétaire du compte</param>
        /// <param name="_solde">Solde du compte</param>
        /// <param name="_decouvert">Découvert autorisé du compte</param>
        public void AjouteCompte(int _numero, string _nom, float _solde, int _decouvert)
        {
            mesComptes.Add(new Compte(_numero, _nom, _solde, _decouvert));
        }

        /// <summary>
        /// Cherche le compte dont le numéro est passé en paramètre
        /// </summary>
        /// <param name="_numero">Numéro du compte à rechercher</param>
        /// <returns>
        /// Le compte s'il est trouvé
        /// Null si non trouvé
        /// </returns>
        public Compte? RendCompte(int _numero)
        {
            int i = 0;
            while (i < mesComptes.Count)
            {
                if (mesComptes[i].Numero == _numero)
                {
                    return mesComptes[i];
                }
                else
                {
                    i++;
                }
            }
            return null;
        }

        public bool Transferer(int _numeroDebit, int _numeroCredit, float _montant)
        {
            Compte? compteDebit = RendCompte(_numeroDebit);
            Compte? compteCredit = RendCompte(_numeroCredit);
            if (compteDebit == null || compteCredit == null) 
            {
                return false;
            }
            else if (compteDebit.TransfererVers(compteCredit, _montant))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
