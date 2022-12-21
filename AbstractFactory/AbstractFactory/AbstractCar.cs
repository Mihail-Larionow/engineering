using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Асбтрактный класс AbstractCar
    abstract class AbstractCar
    {
        //Название автомобиля
        public string Name { get; set; }

        //Вес автомобиля
        public abstract int Weight(AbstractBody body);

        //Максимальная скорость автомобиля
        public abstract int MaxSpeed(AbstractEngine engine);

    }
}
