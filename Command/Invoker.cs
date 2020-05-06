using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// Обращается к команде для выполнения операции;
    /// </summary>
    class Invoker
    {
        private Command command;
        public Command Command
        {
            set
            {
                this.command = value;
            }
        }
        public void Run()
        {
            this.command.Excecute();
        }
        public void Undo()
        {
            this.command.Undo();
        }
    }
}
