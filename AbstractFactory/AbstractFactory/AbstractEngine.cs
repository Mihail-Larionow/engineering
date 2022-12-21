using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Асбтрактный класс AbstractEngine
    abstract class AbstractEngine
    {
        //Максимальная скорость с двигателем
        public int max_speed { get; set; }
    }
}
