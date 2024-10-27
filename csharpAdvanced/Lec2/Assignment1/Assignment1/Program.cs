namespace Lec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();
            processor.CheckOut(new Assignment1.User("amer", new CreditCardPayment()), 155.6);


        }
    }
}
