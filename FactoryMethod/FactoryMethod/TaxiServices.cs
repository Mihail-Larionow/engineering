using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod
{
    //Класс TaxiServices наследующий абстрактный класс TransportService
    internal class TaxiServices : TransportService
    {
        //Категория
        public int Category { get; set; }

        //Конструктор TaxiServices
        public TaxiServices(string name, int cat) : base(name)
        {
            Category = cat;
        }

        //Переопределенный метод CostTransportation
        public override double CostTransportation(double distance)
        {
            return distance * Category;
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, поездка категории {1}",
            Name, Category);
            return s;
        }
    }
}
