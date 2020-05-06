
namespace Command
{
    class TakeOff:Command
    {
        /// <summary>
        /// Класс команды подъёма
        /// </summary>
        /// <param name="plane"></param>
        public TakeOff(Airplane plane) : base(plane)
        {
        }
        public override void Excecute()
        {
            plane.State = "Поднимается";
        }
        public override void Undo()
        {
            plane.State = "Опускается";
        }
    }
}
