// software entities (classec, modules, functions) should be open for extension,
// but closed for modification

using System;

namespace ConsoleApp1
{
    class OCP
    {
        public interface IPaymentMethod
        {
            void Pay();
        }
        public class BkashPayment : IPaymentMethod
        {
            public void Pay()
            {
                Console.WriteLine("Bkash Payment Successful");
            }
        }
        public class NagadPayment : IPaymentMethod
        {
            public void Pay()
            {
                Console.WriteLine("Nagad Payment Successfll");
            }
        }

        public class CardPayment : IPaymentMethod
        {
            public void Pay()
            {
                Console.WriteLine("Card Payment Successful");
            }
        }

        // business logic class
        public class PaymentProcessor()
        {
            public void ProcessPayment(IPaymentMethod paymentMethod)
            {
                paymentMethod.Pay();
            }
        }
        
        public static void Main()
        {
            PaymentProcessor payment = new PaymentProcessor();
            payment.ProcessPayment(new BkashPayment());
            payment.ProcessPayment(new NagadPayment());
            payment.ProcessPayment(new CardPayment());
        }
    }
}