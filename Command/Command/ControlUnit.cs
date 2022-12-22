using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Класс ControlUnit
    internal class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;

        //Метод StoreCommand
        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        //Метод ExecuteCommand
        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        //Метод Undo
        public void Undo()
        {
            commands[current - 1].UnExecute();
        }

        //Перегруженный метод Undo
        public void Undo(int x)
        {
            for (int i = 0; i < x; i++)
            {
                commands[current - 1].UnExecute();
            }
        }

        //Метод Redo
        public void Redo()
        {
            commands[current - 1].Execute();
        }

        //Перегруженный метод Redo
        public void Redo(int x)
        {
            for (int i = 0; i < x; i++)
            {
                commands[current - 1].Execute();
            }
        }
    }
}

