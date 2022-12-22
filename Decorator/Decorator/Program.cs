using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        //Приватный метод Print
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }

        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0); //Экземпляр класса Renault
            Print(reno); //Вызов метода Print

            Chevrolet camaro = new Chevrolet("Шевроле", "Chevrolet Camaro V", 999.0); //Экземпляр класса Chevrolet
            Print(camaro); //Вызов метода Print
            AutoBase mycamaro = new AutoTransmission(camaro, "Комфорт"); //Экземпляр класса AutoTransmission
            Print(mycamaro); //Вызов метода Print
            AutoBase newmycamaro = new AutoStart(new AutoTransmission(camaro, "Комфорт"), "Свобода"); //Экземпляр класса AutoStart
            Print(newmycamaro); //Вызов метода Print
            AutoBase verynewmycamaro = new MediaNAV(newmycamaro, "Навигация"); //Экземпляр класса MediaNAV
            Print(verynewmycamaro); //Вызов метода Print
            AutoBase veryverynewmycamaro = new SystemSecurity(verynewmycamaro, "Безопасность"); //Экземпляр класса SystemSecurity
            Print(veryverynewmycamaro); //Вызов метода Print
        }
    }
}