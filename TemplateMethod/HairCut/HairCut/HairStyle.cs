using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairCut
{
    //Абстрактный класс HairStyle
    abstract class HairStyle
    {
        public string Beggining { get; set; } //Первый член списка

        public List<string> stepList; //Список шагов

        //Конструктор HairStyle
        public HairStyle(string original_style)
        {
            Beggining = original_style;
            stepList = new List<string>();
        }

        //Метод TemplateMethod
        public void TemplateMethod()
        {
            InitializeHairStyle(Beggining);
            Cutting();
            Print(stepList);
        }

        //Метод Print
        private void Print(List<string> stepList)
        {
            Console.WriteLine("Процесс:");
            foreach (var item in stepList)
            {
                Console.WriteLine (" " + item);
            }
            Console.WriteLine();
        }

        //Метод InitializeHairStyle
        private void InitializeHairStyle(string a)
        {
            Beggining = a;
        }

        //Абстрактный метод Cutting
        public abstract void Cutting();
    }
}
