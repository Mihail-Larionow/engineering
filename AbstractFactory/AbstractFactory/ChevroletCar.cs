using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractFactory
{
    //Класс ChevroletCar наследующий абстрактный класс AbstractCar
    internal class ChevroletCar : AbstractCar
    {
        //Конструктор AudiCar
        public ChevroletCar(string name)
        {
            Name = name;
        }

        //Переопределенный метод Weight
        public override int Weight(AbstractBody body)
        {
            int w = body.weight;
            return w;
        }

        //Переопределенный метод MaxSpeed
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }

        //Переопределенный метод ToString()
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
    }
}
