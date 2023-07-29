using System.ComponentModel.DataAnnotations;

namespace ClassLibraryProxy
{
	public class FichierProxy : IFichier
	{
		private FichierSource fichierSource;

		public FichierProxy(FichierSource _fichierSource)
		{
			this.fichierSource = _fichierSource;
		}

		public void Ecrire()
		{
			bool autorisationsValides = VerifierAutorisations();

			// Vérifier les autorisations d'accès
			if (autorisationsValides)
			{
				// Déléguer l'appel à FichierSource pour l'écriture du fichier
				this.fichierSource.Ecrire();
			}
		}

		public void Lire()
		{
			bool autorisationsValides = VerifierAutorisations();

			// Vérifier les autorisations d'accès
			if (autorisationsValides)
			{
				// Déléguer l'appel à FichierSource pour la lecture du fichier
				this.fichierSource.Lire();
			}
		}

		/// <summary>
		/// Vérifier si l'utilisateur a les autorisations 
		/// nécessaires pour accéder au fichier source
		/// </summary>
		/// <returns>bool</returns>
		private bool VerifierAutorisations()
		{
			return true;
		}
	}
}