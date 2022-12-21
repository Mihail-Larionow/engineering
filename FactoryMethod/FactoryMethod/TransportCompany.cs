using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Абстрактный класс TransportCompany
    abstract class TransportCompany
    {
        //Название компании
        public string Name { get; set; } 

        //Конструктор TransportCompany
        public TransportCompany(string n)
        {
            Name = n;
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return Name;
        }

        //Фабричный метод Create
        abstract public TransportService Create(string n, int k);
    }
}
