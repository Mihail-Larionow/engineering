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
            Progression val = new ArithmeticProgression(1, 21, 3); //Экземпляр класса Progression
            val.TemplateMethod(); //Вызов метода TemplateMethod

            val = new GeometricProgression(1, 21, 2); //Экземпляр класса Progression
            val.TemplateMethod(); //Вызов метода TemplateMethod
        }
    }
}