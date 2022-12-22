using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    //Абстрактный класс PaymentHandler
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; } //Объект класса PaymentHandler

        //Абстрактный метод Handle
        public abstract void Handle(Receiver receiver); 
    }
}
