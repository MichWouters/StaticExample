// See https://aka.ms/new-console-template for more information

using StaticExample;


var audi = new Car("Audi", "A5", CarColor.Red);
var ford = new Car("Ford", "Fiesta", CarColor.Blue);

audi.ResprayCar(CarColor.Red);
ford.ResprayCar();

Console.WriteLine(Car.GetCarsProduced());

Console.WriteLine(audi.ToString());
Console.WriteLine();
Console.WriteLine(ford.ToString());

Employee michiel = new Employee();
michiel.Name = "Michiel";
michiel.LastName = "Wouters";
Console.WriteLine(michiel.ToString());
