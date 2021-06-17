using System;

namespace factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input 0 to pay with bkash and 1 for nagad!");
                int paymentMethod = int.Parse(Console.ReadLine());
                PaymentFactory paymentFactory = new PaymentFactory();
                IPayment paymentInstance = paymentFactory.getInstance(paymentMethod);
                Console.WriteLine(paymentInstance.pay(500));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
