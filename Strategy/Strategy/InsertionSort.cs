using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Класс InsertionSort наследующий StrategySort
    class InsertionSort : StrategySort
    {
        //Конструктор InsertionSort
        public InsertionSort()
        {
            Title = "Сортировка вставками";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Title;
        }

        //Переопределенный метод Sort
        public override void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                        break;
                    array[j + 1] = array[j];
                }
                array[j + 1] = buffer;
            }
        }
    }
}
