using CLEmployees;

Employee david = new Employee("David", 2000);
Employee sandrine = new Employee("Sandrine", 1700);
Manager florent = new Manager("Florent", 3000);
florent.Add(david);
florent.Add(sandrine);
florent.Accept(new DetailsVisitor());
