using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Класс TaxiTransCom наследующий абстрактный класс TransportCompany
    internal class TaxiTransCom : TransportCompany
    {
        //Конструктор TaxiTransCom
        public TaxiTransCom(string name) : base(name) { }

        //Переопределенный фабричный метод Create
        public override TransportService Create(string n, int c)
        {
            return new TaxiServices(Name, c);
        }
    }
}
