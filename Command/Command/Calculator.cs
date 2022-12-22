using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Command.ConcreteCommand;

namespace Command
{
    //Класс Calculator
    internal class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        //Калькулятор Calculator
        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        //Приватный метод Run
        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        //Метод Undo
        public double Undo()
        {
            controlUnit.Undo();
            return arithmeticUnit.Register;
        }

        //Перегруженный метод Undo
        public double Undo(int x)
        {
            controlUnit.Undo(x);
            return arithmeticUnit.Register;
        }

        //Метод Redo
        public double Redo()
        {
            controlUnit.Redo();
            return arithmeticUnit.Register;
        }

        //Перегруженный метод Redo
        public double Redo(int x)
        {
            controlUnit.Redo(x);
            return arithmeticUnit.Register;
        }

        //Метод Add
        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        //Метод Sub
        public double Sub(double operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }

        //Метод Prod
        public double Prod(double operand)
        {
            return Run(new Prod(arithmeticUnit, operand));
        }

        //Метод Div
        public double Div(double operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }
    }
}
