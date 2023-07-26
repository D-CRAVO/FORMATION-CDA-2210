using ClassLibraryProxy;

// FichierSource

FichierSource fichierSource = new FichierSource();

// Client -> FichierProxy -> FichierSource

FichierProxy fichierProxy = new FichierProxy(fichierSource);

fichierProxy.Lire();
fichierProxy.Ecrire();
