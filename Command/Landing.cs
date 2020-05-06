using System;

namespace Command
{
    /// <summary>
    /// Класс команды спуска
    /// </summary>
    class Landing:Command
    {
        public Landing(Airplane plane) : base(plane)
        {
        }
        public override void Excecute()
        {
            plane.State = "Опускается";
        }
        public override void Undo()
        {
            plane.State = "Поднимается";
        }
    }
}
