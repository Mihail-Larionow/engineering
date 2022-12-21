using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс ChevroletFactory наследующий абстрактный класс CarFactory
    internal class ChevroletFactory : CarFactory
    {
        //Приватный конструктор ChevroletFactory
        private ChevroletFactory() { }

        //Отложенная инициализация ChevroletFactory
        static Lazy<ChevroletFactory> factory = new Lazy<ChevroletFactory>(() => new ChevroletFactory());

        //Статический метод Factory
        public static ChevroletFactory Factory
        {
            get
            {
                return factory.Value;
            }
        }

        //Переопределенный метод CreateCar
        public override AbstractCar CreateCar()
        {
            return new ChevroletCar("Шевроле");
        }

        //Переопределенный метод CreateBody
        public override AbstractBody CreateBody()
        {
            return new ChevroletBody();
        }

        //Переопределенный метод CreateEngine
        public override AbstractEngine CreateEngine()
        {
            return new ChevroletEngine();
        }
    }
}
