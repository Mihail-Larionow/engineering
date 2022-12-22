using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Класс ConcreteCommand
    internal class ConcreteCommand
    {
        //Класс Add наследующий абстрактный класс Command
        internal class Add : Command
        {
            //Конструктор Add
            public Add(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            //Переопределенный метод Execute
            public override void Execute()
            {
                unit.Run('+', operand);
            }

            //Переопределенный метод UnExecute
            public override void UnExecute()

            {
                unit.Run('-', operand);
            }
        }

        //Класс Sub наследующий абстрактный класс Command
        internal class Sub : Command
        {
            //Конструктор Sub
            public Sub(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            //Переопределенный метод Execute
            public override void Execute()
            {
                unit.Run('-', operand);
            }

            //Переопределенный метод UnExecute
            public override void UnExecute()

            {
                unit.Run('+', operand);
            }
        }

        //Класс Prod наследующий абстрактный класс Command
        internal class Prod : Command
        {
            //Конструктор Prod
            public Prod(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            //Переопределенный метод Execute
            public override void Execute()
            {
                unit.Run('*', operand);
            }

            //Переопределенный метод UnExecute
            public override void UnExecute()
            {
                unit.Run('/', operand);
            }
        }

        //Класс Div наследующий абстрактный класс Command
        internal class Div : Command
        {
            //Конструктор Div
            public Div(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            //Переопределенный метод Execute
            public override void Execute()
            {
                unit.Run('/', operand);
            }

            //Переопределенный метод UnExecute
            public override void UnExecute()
            {
                unit.Run('*', operand);
            }
        }
    }
}
