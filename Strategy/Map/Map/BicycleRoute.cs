using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    //Класс BicycleRoute наследующий абстрактный класс StrategyRoute
    internal class BicycleRoute : StrategyRoute
    {
        //Конструктор BicycleRoute
        public BicycleRoute()
        {
            Title = "На велосипеде";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод FindRoute
        public override void FindRoute(string[] places)
        {
            for (int i = 2; i < places.Length - 1; i += 3)
            {
                places[i] = "";
            }
        }
    }
}
