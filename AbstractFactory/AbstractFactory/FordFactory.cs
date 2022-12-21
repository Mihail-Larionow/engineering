using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс FordFactory наследующий абстрактный класс CarFactory
    internal class FordFactory : CarFactory
    {
        //Переопределенный метод CreateCar
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }

        //Переопределенный метод CreateBody
        public override AbstractBody CreateBody()
        {
            return new FordBody();
        }

        //Переопределенный метод CreateEngine
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
    }
}
