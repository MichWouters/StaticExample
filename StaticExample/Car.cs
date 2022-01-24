namespace StaticExample
{
    public class Car
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public CarColor CarColor { get; set; }

        // A static variable describes the class rather than an instance.
        private static int carsProduced;

        public Car(string manufacturer, string model, CarColor carColor)
        {
            Manufacturer = manufacturer;
            Model = model;
            CarColor = carColor;

            carsProduced++;
        }

        public void ResprayCar(CarColor carColor = CarColor.Silver)
        {
            CarColor = carColor;
        }

        public override string ToString()
        {
            string result = $"Car Details: \nManufacturer: {Manufacturer}\nModel:{Model}\nColor: {CarColor}";
            return result;
        }
        
        // A static method can only call other static methods and variables.
        public static int GetCarsProduced()
        {
            return carsProduced;
        }
    }

    public enum CarColor
    {
        Silver, Red, Blue, Green, BlueGreen, Yellow
    }
}