using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс Client
    internal class Client
    {
        private AbstractCar abstractCar; //Приватный объект AbstractCar
        private AbstractBody abstractBody; //Приватный объект AbstractBody
        private AbstractEngine abstractEngine; //Приватный объект AbstractEngine

        //Конструктор Client
        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractBody = car_factory.CreateBody();
            abstractEngine = car_factory.CreateEngine();
        }
        //Метод Weight
        public int Weght()
        {
            return abstractCar.Weight(abstractBody);
        }

        //Метод RunMaxSpeed
        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return abstractCar.ToString();
        }
    }
}
