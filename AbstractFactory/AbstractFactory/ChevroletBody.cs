using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс ChevroletBody наследующий абстрактный класс AbstractBody
    internal class ChevroletBody : AbstractBody
    {
        //Конструктор AudiBody
        public ChevroletBody()
        {
            weight = 960;
        }
    }
}
