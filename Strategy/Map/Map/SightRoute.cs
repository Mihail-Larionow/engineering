using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    //Класс SightRoute наследующий абстрактный класс StrategyRoute
    internal class SightRoute : StrategyRoute
    {
        //Конструктор SightRoute
        public SightRoute()
        {
            Title = "По достопримечательностям";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод FindRoute
        public override void FindRoute(string[] places)
        {
            for (int i = 3; i < places.Length - 1; i += 3) 
            {
                places[i] = "";
            }
        }
    }
}
