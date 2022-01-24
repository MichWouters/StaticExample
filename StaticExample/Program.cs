using StaticExample;

var audi = new Car("Audi", "A5", CarColor.Red);
var ford = new Car("Ford", "Fiesta", CarColor.Blue);

Console.WriteLine(audi.ToString());
Console.WriteLine();

audi.ResprayCar(CarColor.Red);
Console.WriteLine(audi.ToString());
Console.WriteLine();

Console.WriteLine(ford.ToString());
Console.WriteLine();

// A static methode is called on the Class itself rather than on an instance
Console.WriteLine($"Amount of cars produced: {Car.GetCarsProduced()}");

Console.ReadLine();