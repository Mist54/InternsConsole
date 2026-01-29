using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsConsole
{
    // Abstract class
    abstract class Payment
    {
        public void PaymentStarted()
        {
            Console.WriteLine("Payment process started");
        }

        public abstract void MakePayment(double amount);
    }

    // Child class 1
    class CashPayment : Payment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine("Cash payment completed: " + amount);
        }
    }

    // Child class 2
    class CardPayment : Payment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine("Card payment completed: " + amount);
        }
    }

}
