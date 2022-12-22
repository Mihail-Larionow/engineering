using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Класс SelectionSort наследующий StrategySort
    class SelectionSort : StrategySort
    {
        //Конструктор SelectionSort
        public SelectionSort()
        {
            Title = "Сортировка выбором";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод Sort
        public override void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[k] > array[j])
                        k = j;
                if (k != i)
                {
                    int temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
