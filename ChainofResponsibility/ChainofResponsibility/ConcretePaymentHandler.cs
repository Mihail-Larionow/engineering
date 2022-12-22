using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    //Класс ConcretePaymentHandler
    internal class ConcretePaymentHandler
    {
        //Класс BankPaymentHandler наследующий PaymentHandler
        internal class BankPaymentHandler : PaymentHandler
        {
            //Переопределенный метод Handle
            public override void Handle(Receiver receiver)
            {
                if (receiver.BankTransfer == true)
                    Console.WriteLine("Выполняем банковский перевод");
                else if (Successor != null)
                    Successor.Handle(receiver);
            }
        }

        //Класс MoneyPaymentHandler наследующий PaymentHandler
        internal class MoneyPaymentHandler : PaymentHandler
        {
            //Переопределенный метод Handle
            public override void Handle(Receiver receiver)
            {
                if (receiver.MoneyTransfer == true)
                    Console.WriteLine("Выполняем перевод через системы денежных переводов");
                else if (Successor != null)
                    Successor.Handle(receiver);
            }
        }

        //Класс PayPalPaymentHandler наследующий PaymentHandler
        internal class PayPalPaymentHandler : PaymentHandler
        {
            //Переопределенный метод Handle
            public override void Handle(Receiver receiver)
            {
                if (receiver.PayPalTransfer == true)
                    Console.WriteLine("Выполняем перевод через систему PayPal");
                else if (Successor != null)
                    Successor.Handle(receiver);
            }
        }
    }
}
