using static Algo_L3_Dynamic_Struct.QueueCleaner;
using static Algo_L3_Dynamic_Struct.MinOfMaxes;

namespace Algo_L3_Dynamic_Struct
{
    class Program
    {
        public static void Switcher()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.Clear();
            Console.WriteLine("1 - Очищення черги від цифр");
            Console.WriteLine("2 - Обчислення мінімуму серед максимумів у парах");
            Console.WriteLine("0 - Вихід");
            Console.WriteLine("Введіть номер завдання:");
            try
            {
                byte task = byte.Parse(Console.ReadLine());
                switch (task)
                {
                    case 0: Console.WriteLine("Чекаємо на повернення!"); break;
                    case 1: QueueInit(); break;
                    case 2: MiniMaxInit(); break;
                    default: throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильне введення!");
                Console.ReadKey();
                Switcher();
            }
        }
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Switcher();
        }
    }
}