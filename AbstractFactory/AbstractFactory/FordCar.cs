using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс FordCar наследующий абстрактный класс AbstractCar
    internal class FordCar : AbstractCar
    {
        //Конструктор FordCar
        public FordCar(string name)
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
