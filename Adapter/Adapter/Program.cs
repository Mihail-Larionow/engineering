using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit fahr = new Fahrenheit();
            Celsius cels = new Celsius();
            Thermometer therm = new Thermometer();

            ITemperature mcels = new TemperatureAdapter(cels); //Экземпляр класса адаптер

            Console.WriteLine("Температура за бортом: {0} Фаренгейт или {1:0.00} градусов Цельсия", //Вывод
                therm.Measuring(fahr), therm.Measuring(mcels)); 
        }
    }
}