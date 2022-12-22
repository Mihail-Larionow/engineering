using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(); //Экземпляр класса Calculator
            double result = 0; 
            result = calculator.Add(5); //Вызов метода Add
            Console.WriteLine(result); //Вывод результата
            result = calculator.Add(4); //Вызов метода Add
            Console.WriteLine(result); //Вывод результата
            result = calculator.Add(3); //Вызов метода Add
            Console.WriteLine(result); //Вывод результата
            result = calculator.Redo(); //Вызов метода Redo
            Console.WriteLine(result); //Вывод результата
            result = calculator.Undo(); //Вызов метода Undo
            Console.WriteLine(result); //Вывод результата

            result = calculator.Prod(4); //Вызов метода Prod
            Console.WriteLine(result); //Вывод результата
            result = calculator.Undo(2); //Вызов метода Undo
            Console.WriteLine(result); //Вывод результата
            result = calculator.Div(3); //Вызов метода Div
            Console.WriteLine(result); //Вывод результата
        }
    }
}