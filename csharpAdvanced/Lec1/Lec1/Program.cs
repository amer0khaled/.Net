namespace Lec1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ac1 = new(123, "amer");

            Console.WriteLine(ac1.AccountNumber);
            Console.WriteLine(ac1.AccountHoldName);
            Console.WriteLine(ac1.Balance);

            ac1.Deposite(5000);

            Console.WriteLine(ac1.Balance);

            ac1.Withdraw(123, -65);

            Console.WriteLine(ac1.Balance);


        }
    }
}
