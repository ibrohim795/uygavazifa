namespace uygavazifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(777,"CHevrolet","Onix",100,15);
            Console.WriteLine( car.CalculaTetotal());
            Car.TaxPercentage = 50;
            Console.WriteLine(car.CalculaTetotal());
        }
    }
}