using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    //Абстрактный класс StrategyRoute
    abstract class StrategyRoute
    {
        //Название стратегии
        public string Title { get; set; }

        //Абстрактный метод FindRoute
        public abstract void FindRoute(string[] places);
    }
}
