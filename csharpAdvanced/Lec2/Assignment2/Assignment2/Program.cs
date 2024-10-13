namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(); 
            Vehicle motorcycle = new Motorcycle(); 
            Vehicle truck = new Truck();

            car.Started();
            car.Stop();
            car.Describe();

            Console.WriteLine("-----------");

            truck.Started();
            truck.Stop();
            truck.Describe();

            Console.WriteLine("-----------");

            motorcycle.Started();
            motorcycle.Stop();
            motorcycle.Describe();
        }
    }
}
