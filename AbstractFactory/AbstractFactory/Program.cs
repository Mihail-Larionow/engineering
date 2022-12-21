using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory(); //Экземпляр класса FordFactory
            CarFactory audi_car = new AudiFactory(); //Экземпляр класса AudiFactory
            Client c1 = new Client(ford_car); //Экземпляр класса Client
            Client c2 = new Client(audi_car); //Экземпляр класса Client
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час. Вес кузова: {2} кг", c1.ToString(), c1.RunMaxSpeed(), c1.Weght()); //Вывод
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час. Вес кузова: {2} кг", c2.ToString(), c2.RunMaxSpeed(), c2.Weght()); //Вывод
        }
    }
}