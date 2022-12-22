using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    //Класс FootRoute наследующий абстрактный класс StrategyRoute
    internal class FootRoute : StrategyRoute
    {
        //Конструктор FootRoute
        public FootRoute()
        {
            Title = "Пешком";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод FindRoute
        public override void FindRoute(string[] places)
        {
            for (int i = 0; i < places.Length - 1; i += 10)
            {
                places[i] = "";
            }
        }
    }
}
