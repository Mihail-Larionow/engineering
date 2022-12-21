using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс FordEngine наследующий абстрактный класс AbstractEngine
    internal class FordEngine : AbstractEngine
    {
        //Конструктор FordEngine
        public FordEngine()
        {
            max_speed = 220;
        }
    }
}
