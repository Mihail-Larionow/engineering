using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Абстрактный класс Command
    abstract class Command
    {
        protected ArithmeticUnit unit; 
        protected double operand;

        //Абстрактный метод Execute
        public abstract void Execute();

        //Абстрактный метод UnExecute
        public abstract void UnExecute();
    }
}
