using ChainofResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChainofResponsibility.ConcretePaymentHandler;

namespace ChainofResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true); //Экземпляр класса Receiver
            PaymentHandler bankPaymentHandler = new BankPaymentHandler(); //Экземпляр класса BankPaymentHandler
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler(); //Экземпляр класса MoneyPaymentHandler
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler(); //Экземпляр класса PayPalPaymentHandler
            bankPaymentHandler.Successor = moneyPaymentHnadler;  //Добавление в цепочку объекта moneyPaymentHnadler
            moneyPaymentHnadler.Successor = paypalPaymentHandler; //Добавление в цепочку объекта paypalPaymentHandler
            bankPaymentHandler.Handle(receiver); //Вызов метода Handle

            paypalPaymentHandler.Handle(receiver); //Вызов метода Handle

            receiver = new Receiver(true, false, false); //Экземпляр класса Receiver
            bankPaymentHandler = new BankPaymentHandler(); //Экземпляр класса BankPaymentHandler
            moneyPaymentHnadler = new MoneyPaymentHandler(); //Экземпляр класса MoneyPaymentHandler
            paypalPaymentHandler.Successor = moneyPaymentHnadler; //Добавление в цепочку объекта moneyPaymentHnadler
            moneyPaymentHnadler.Successor = bankPaymentHandler; //Добавление в цепочку объекта bankPaymentHandler
            paypalPaymentHandler.Handle(receiver); //Вызов метода Handle
        }
    }
}