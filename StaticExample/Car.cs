namespace StaticExample
{
    public class Car
    {
        public string Manufacturer { get; set; } 

        public string Model { get; set; }

        public CarColor CarColor { get; set; }


        private static int carsProduced;

        public Car(string manufacturer, string model, CarColor carColor)
        {
            Manufacturer = "Mercedes"; 
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