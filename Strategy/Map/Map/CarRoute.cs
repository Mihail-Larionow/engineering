using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    //Класс CarRoute наследующий абстрактный класс StrategyRoute
    internal class CarRoute : StrategyRoute
    {
        //Конструктор CarRoute
        public CarRoute()
        {
            Title = "На машине";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод FindRoute
        public override void FindRoute(string[] places)
        {
            for (int i = 1; i < places.Length - 1; i += 2)
            {
                places[i] = "";
            }
        }
    }
}
