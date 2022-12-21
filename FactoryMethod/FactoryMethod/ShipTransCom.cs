using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Класс ShipTransCom наследующий абстрактный класс TransportCompany
    internal class ShipTransCom : TransportCompany
    {
        //Конструктор ShipTransCom
        public ShipTransCom(string name) : base(name) { }

        //Переопределенный фабричный метод Create
        public override TransportService Create(string n, int t)
        {
            return new Shipping(Name, t);
        }
    }
}
