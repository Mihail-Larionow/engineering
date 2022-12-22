using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Абстрактный класс Sort
    abstract class StrategySort
    {
        //Название стратегии
        public string Title { get; set; }

        //Абстрактный метод Sort
        public abstract void Sort(int[] array);
    }
}
