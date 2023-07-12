using DesignPatternComposite;

Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
double resultat1 = exp1.Evalue();
Console.WriteLine(resultat1);

Expression exp2 = new Addition(new Nombre(33), new Addition (new Nombre(33), new Nombre(11)));
double resultat2 = exp2.Evalue();
Console.WriteLine(resultat2);

string resultat3 = "essai";