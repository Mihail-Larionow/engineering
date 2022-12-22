using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    //Класс Receiver
    internal class Receiver
    {
        //Банковские переводы
        public bool BankTransfer { get; set; }

        //Денежные переводы - WesternUnion, Unistream
        public bool MoneyTransfer { get; set; }

        //Перевод через PayPal
        public bool PayPalTransfer { get; set; }

        //Конструктор Receiver
        public Receiver(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}
