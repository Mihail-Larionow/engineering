using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        //Приватный метод Print
        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}",
            compTax.ToString(), distg, compTax.CostTransportation(distg));
        }

        static void Main(string[] args)
        {
            TransportCompany trCom = new TaxiTransCom("Служба такси"); //Экземпляр класса TaxiTransCom
            TransportService compService = trCom.Create("Такси", 1); //Экземпляр абстрактного класса TransportService, созданный фабричным методом
            double dist = 15.5; //Дистанция
            Print(compService, dist); //Вывод при помощи метода Print

            TransportCompany gCom = new ShipTransCom("Служба перевозок"); //Экземпляр класса ShipTransCom
            compService = gCom.Create("Грузоперевозки", 2); //Экземпляр абстрактного класса TransportService, созданный фабричным методом
            double distg = 150.5; //Дистанция
            Print(compService, distg); //Вывод при помощи метода Print

            TransportCompany ddCom = new DrunkTransCom("Служба перевозки тел"); //Экземпляр класса DrunkTransCom
            compService = ddCom.Create("Пьяный водитель", 4); //Экземпляр абстрактного класса TransportService, созданный фабричным методом
            double distd = 100; //Дистанция
            Print(compService, distd); //Вывод при помощи метода Print
        }
    }
}