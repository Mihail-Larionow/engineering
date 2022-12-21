using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс FordBody наследующий абстрактный класс AbstractBody
    internal class FordBody : AbstractBody
    {
        //Конструктор FordBody
        public FordBody()
        {
            weight = 1110;
        }
    }
}
