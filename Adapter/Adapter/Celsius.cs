using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Класс Celsius, который по условию не поддерживает интерфейс ITemperature
    internal class Celsius
    {
        //Метод возвращения температуры в градусах Цельсия
        public double MeasurementC(double fahrenheits)
        {
            double cels = (fahrenheits - 32) * 5 / 9;
            return cels;
        }
    }
}
