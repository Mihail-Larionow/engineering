using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс AudiEngine наследующий абстрактный класс AbstractEngine
    internal class AudiEngine : AbstractEngine
    {
        //Конструктор AudiEngine 
        public AudiEngine()
        {
            max_speed = 260;
        }
    }
}
