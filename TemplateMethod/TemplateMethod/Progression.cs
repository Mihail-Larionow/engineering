using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //Абстрактный класс Progression
    abstract class Progression
    {
        public int First { get; set; } //Первый член прогрессии
        public int Last { get; set; } //Последний член прогрессии
        public int H { get; set; } //Шаг прогрессии

        public List<int> progList; //Список членов прогрессии

        //Конструктор Progression
        public Progression(int first, int last, int h)
        {
            First = first;
            Last = last;
            H = h;
            progList = new List<int>();
        }

        //Метод TemplateMethod
        public void TemplateMethod()
        {
            InitializeProgression(First, Last, H);
            Progress();
            Print(progList);
        }

        //Метод Print
        private void Print(List<int> progList)
        {
            Console.WriteLine("Последовательность:");
            foreach (var item in progList)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }

        //Метод InitializeProgression
        private void InitializeProgression(int a, int b, int h)
        {
            First = a;
            Last = b;
            H = h;
        }

        //Абстрактный метод Progress
        public abstract void Progress();
    }
}
