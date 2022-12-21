using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod
{
    //Класс DrunkTransCom наследующий абстрактный класс TransportCompany
    internal class DrunkTransCom : TransportCompany
    {
        //Конструктор DrunkTransCom
        public DrunkTransCom(string name) : base(name) { }

        //Переопределенный фабричный метод Create
        public override TransportService Create(string n, int c)
        {
            return new DrunkDriver(Name, c);
        }
    }
}
