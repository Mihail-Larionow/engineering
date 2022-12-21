using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Абстрактный класс TransportService
    abstract class TransportService
    {
        //Название услуги
        public string Name { get; set; }

        //Конструктор TransportService
        public TransportService(string name)
        {
            Name = name;
        }

        //Абстрактный метод CostTransportation
        abstract public double CostTransportation(double distance);
    }
}
