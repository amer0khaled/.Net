namespace Lec2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            OnlineStore store1 = new OnlineStore(new PayPal());
            OnlineStore store2 = new OnlineStore(new BankTransfer());
            OnlineStore store3 = new OnlineStore(new CreditCardPayment());

            store1.PayBill();
            store2.PayBill();
            store3.PayBill();
        }
    }
}
