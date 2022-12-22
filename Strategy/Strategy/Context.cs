using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Класс Context
    internal class Context
    {
        StrategySort strategy;
        int[] array;

        //Конструктор Context
        public Context(StrategySort strategy, int[] array)
        {
            this.strategy = strategy;
            this.array = array;
        }

        //Метод Sort
        public void Sort()
        {
            strategy.Sort(array);
        }

        //Метод PrintArray
        public void PrintArray()
        {
            Console.WriteLine(strategy.ToString());
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
