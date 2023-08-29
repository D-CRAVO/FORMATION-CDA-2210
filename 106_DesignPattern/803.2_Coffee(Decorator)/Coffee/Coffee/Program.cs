using Coffee;

Cappuccino cappuccino = new Cappuccino();
Console.WriteLine(cappuccino.GetDescription());

Milk milk = new Milk(cappuccino);
Console.WriteLine(milk.GetDescription());
Console.WriteLine(milk.GetPrice());
