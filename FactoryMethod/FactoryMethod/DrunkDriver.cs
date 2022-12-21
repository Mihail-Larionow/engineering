using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod
{
    //Класс DrunkDriver наследующий абстрактный класс TransportService
    internal class DrunkDriver : TransportService
    {
        //Количество
        public double Quantity { get; set; }

        //Конструктор DrunkDriver
        public DrunkDriver(string name, int qua) : base(name)
        {
            Quantity = qua;
        }

        //Переопределенный метод CostTransportation
        public override double CostTransportation(double distance)
        {
            return distance * Quantity;
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, поездка с пьяным водителем, в количестве {1} шт.",
            Name, Quantity);
            return s;
        }
    }
}
