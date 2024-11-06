using static Algo_L3_Dynamic_Struct.Program;

namespace Algo_L3_Dynamic_Struct
{
    internal class QueueCleaner
    {
        public static void QueueInit()
        {             
            // Введення символів
            Console.Write("Введіть символи: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Порожній рядок не є допустимим!");
                Console.ReadKey();
                QueueInit();
            }
            Cleanup(input);
        }
        static void Cleanup(string input)
        {

            // Створення черги
            Queue<char> queue = new Queue<char>();

            // Заповнення черги символами
            foreach (char c in input)
            {
                queue.Enqueue(c);
            }

            // Створення нової черги для символів без цифр
            Queue<char> resultQueue = new Queue<char>();

            // Видаляємо цифри
            while (queue.Count > 0)
            {
                char c = queue.Dequeue();
                if (!char.IsDigit(c)) // Перевірка, що символ не є цифрою
                {
                    resultQueue.Enqueue(c);
                }
                Console.Write($"{string.Join("", queue)}\n");
            }

            // Виведення результату
            Console.Write("Черга без цифр: ");
            foreach (char c in resultQueue)
            {
                Console.Write(c);
            }

            Console.WriteLine("\nНатисніть довільну клавішу, щоб продовжити.");
            Console.ReadKey();
            Switcher();
        }
    }
}
