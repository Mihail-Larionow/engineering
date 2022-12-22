using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Класс BubbleSort наследующий StrategySort
    internal class BubbleSort : StrategySort
    {
        //Конструктор BubbleSort
        public BubbleSort()
        {
            Title = "Сортировка пуырьком";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод Sort
        public override void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j]; 
                        array[j] = array[j + 1]; 
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
