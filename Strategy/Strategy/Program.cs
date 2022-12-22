using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 31, 15, 10, 2, 4, 2, 14, 23, 12, 66 }; //Массив чисел
            StrategySort sort = new SelectionSort(); //Экземпляр класса StrategySort
            Context context = new Context(sort, arr1); //Экземпляр класса Context
            context.Sort(); //Сортировка массива
            context.PrintArray(); //Вывод массива

            int[] arr2 = { 1, 5, 10, 2, 4, 12, 14, 23, 12, 66 }; //Массив чисел
            sort = new InsertionSort(); //Экземпляр класса StrategySort
            context = new Context(sort, arr2); //Экземпляр класса Context
            context.Sort(); //Сортировка массива
            context.PrintArray(); //Вывод массива

            int[] arr3 = { 1, 100, 10, 3, 6, 21, 14, 18, 21, 77 }; //Массив чисел
            sort = new BubbleSort(); //Экземпляр класса StrategySort
            context = new Context(sort, arr3); //Экземпляр класса Context
            context.Sort(); //Сортировка массива
            context.PrintArray(); //Вывод массива
        }
    }
}