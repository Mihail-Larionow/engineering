using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Асбтрактный класс CarFactory
    abstract class CarFactory
    {
        //Абстрактный метод CreateCar
        public abstract AbstractCar CreateCar();

        //Абстрактный метод CreateBody
        public abstract AbstractBody CreateBody();

        //Абстрактный метод CreateEngine
        public abstract AbstractEngine CreateEngine();
    }
}
