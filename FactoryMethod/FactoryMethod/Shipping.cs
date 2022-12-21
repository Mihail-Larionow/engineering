using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Класс Shipping наследующий абстрактный класс TransportService
    internal class Shipping : TransportService
    {
        //Тариф
        public double Tariff { get; set; }

        //Конструктор Shipping
        public Shipping(string name, int taff) : base(name)
        {
            Tariff = taff;
        }

        //Переопределенный метод CostTransportation
        public override double CostTransportation(double distance)
        {
            return distance * Tariff;
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, доставка по тарифу {1}",
            Name, Tariff);
            return s;
        }
    }
}
