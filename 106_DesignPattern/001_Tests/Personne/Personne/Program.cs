using CLEssai;

Personne john = new Personne(55, "John");
Personne jane = new Personne(12, "Jane");
Personne victor = new Personne(20, "Victor");
List<Personne> list = new List<Personne>();
list.Add(john);
list.Add(jane);
list.Add(victor);
list.Sort();
foreach (Personne n in list)
{
    Console.WriteLine(n.Name + " a pour âge " + n.Age);
}

Perroquet perroquet = new Perroquet();

perroquet.parler();
jane.parler();

