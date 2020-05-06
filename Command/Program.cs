using System;

namespace Command
{
    /// <summary>
    /// Сама программа
    /// </summary>
    class Program
    {
        /// <summary>
        /// Начало программы
        /// </summary>
        static void Main(string[] args)
        {
            Airplane plane = new Airplane();
            Invoker flyingControl = new Invoker();
            int a = 0;
            Console.WriteLine("Доступные команды:\n" +
                "1-Набирать высоту\n" +
                "2-Опускаться\n" +
                "3-Отмена команды\n" +
                "4-Отказ от подачи команд");
            do
            {
                a = PlaneControl(plane, flyingControl);
                Console.WriteLine();
            }
            while (a != 4);
        }
        /// <summary>
        /// Метод меняет состояние самолёта
        /// </summary>
        /// <param name="plane">Самолёт</param>
        /// <param name="receiver">Исполнитель команд</param>
        /// <returns></returns>
        private static int PlaneControl(Airplane plane, Invoker receiver)
        {
            Console.WriteLine("Что делать самолёту? ");
            int a = 1;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 1 && a != 2 && a != 3 && a != 4)
                {
                    throw new Exception("Неверная команда");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Введите команду правильно");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Такой команды нет");
                return 0;
            }

            switch (a)
            {
                case 1:
                    {
                        receiver.Command = new TakeOff(plane);
                        receiver.Run();
                    }
                    ; break;
                case 2:
                    {
                        receiver.Command = new Landing(plane);
                        receiver.Run();
                    }
                    ; break;
                case 3:
                    receiver.Undo();
                    ; break;
            }
            Console.WriteLine(plane.State);
            return a;
        }
    }
}
