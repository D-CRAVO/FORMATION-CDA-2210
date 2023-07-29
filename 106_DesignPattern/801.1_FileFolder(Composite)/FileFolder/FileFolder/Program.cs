using CLFileFolder;

CLFileFolder.File file1 = new CLFileFolder.File("File1", "contenu1");
CLFileFolder.File file2 = new CLFileFolder.File("File2", "contenu2");
Console.WriteLine($"Le fichier {file2.Name} a pour taille {file2.Size()} caractères");

Folder folder = new Folder("Folder");
folder.Add(file1);
folder.Add(file2);
Console.WriteLine($"Le dossier {folder} a pour taille {folder.Size()} caractères");
folder.Remove(file1);
Console.WriteLine($"Le dossier {folder} a pour taille {folder.Size()} caractères");
