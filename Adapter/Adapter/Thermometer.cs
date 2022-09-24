using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Adapter
{
    //Класс Thermometer
    internal class Thermometer
    {
        Random r;
        double fahrenheits;
        public Thermometer()
        {
            r = new Random();
            fahrenheits = r.Next(361) - 148; //Случайная температура в Фаренгейтах от -148 до 212
        }
        public double Measuring(ITemperature it)
        {
            return it.Measurement(fahrenheits); //Возвращаем значение температуры
        }
    }
}
