using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Класс AudiFactory наследующий абстрактный класс CarFactory
    internal class AudiFactory : CarFactory
    {
        //Переопределенный метод CreateCar
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Ауди");
        }

        //Переопределенный метод CreateBody
        public override AbstractBody CreateBody()
        {
            return new AudiBody();
        }

        //Переопределенный метод CreateEngine
        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }   
    }
}
