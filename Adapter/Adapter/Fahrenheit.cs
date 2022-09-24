using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Класс Fahrenheit
    internal class Fahrenheit : ITemperature
    {
        //Реализованный метод возвращения температуры
        public double Measurement(double fahrenheits)
        {
            return fahrenheits;
        }
    }
}
