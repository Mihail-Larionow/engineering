using HairCut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы пришли в парикмахерскую.");
            Console.WriteLine();

            HairStyle val = new KarehStyle("Прямые волосы"); //Экземпляр класса HairStyle
            val.TemplateMethod(); //Вызов метода TemplateMethod

            val = new CurlyStyle("Каре"); //Экземпляр класса HairStyle
            val.TemplateMethod(); //Вызов метода TemplateMethod

            val = new StraightStyle("Кудряшки"); //Экземпляр класса HairStyle
            val.TemplateMethod(); //Вызов метода TemplateMethod
        }
    }
}