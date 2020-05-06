
namespace Command
{
    /// <summary>
    /// Абстрактный класс команд для самолёта
    /// </summary>
    abstract class Command
    {
        protected Airplane plane;
        public abstract void Excecute();
        public abstract void Undo();
        public Command(Airplane plane)
        {
            this.plane = plane;
        }
    }
}
