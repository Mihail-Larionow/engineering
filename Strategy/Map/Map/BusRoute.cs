using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    //Класс BusRoute наследующий абстрактный класс StrategyRoute
    internal class BusRoute : StrategyRoute
    {
        //Конструктор BusRoute
        public BusRoute()
        {
            Title = "На общественном транспорте";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод FindRoute
        public override void FindRoute(string[] places)
        {
            for (int i = 2; i < places.Length - 1; i += 2)
            {
                places[i] = "";
            }
        }
    }
}
