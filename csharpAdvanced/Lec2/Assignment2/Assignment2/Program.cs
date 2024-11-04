namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(); 
            Vehicle motorcycle = new Motorcycle(); 
            Vehicle truck = new Truck();

            car.Start();
            car.Stop();
            car.Describe();

            Console.WriteLine("-----------");

            truck.Start();
            truck.Stop();
            truck.Describe();

            Console.WriteLine("-----------");

            motorcycle.Start();
            motorcycle.Stop();
            motorcycle.Describe();
        }
    }
}
