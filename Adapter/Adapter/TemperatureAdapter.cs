using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Класс адаптер для класса Цельсий
    internal class TemperatureAdapter : ITemperature
    {
        Celsius cels; //Ссылка на адаптируемый объект
        public TemperatureAdapter(Celsius cels)
        {
            this.cels = cels;
        }
        //Реализованный метод возвращения температуры
        public double Measurement(double temperature)
        {
            return cels.MeasurementC(temperature);
        }
    }
}
