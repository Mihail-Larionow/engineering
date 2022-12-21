using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс ChevroletEngine наследующий абстрактный класс AbstractEngine
    internal class ChevroletEngine : AbstractEngine
    {
        //Конструктор AudiEngine 
        public ChevroletEngine()
        {
            max_speed = 280;
        }
    }
}
