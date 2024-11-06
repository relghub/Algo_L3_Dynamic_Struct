using static Algo_L3_Dynamic_Struct.Program;

namespace Algo_L3_Dynamic_Struct
{
    internal class MinOfMaxes
    {
        static void MinSearch(int n, double[] numbers)
        {
            // Стек для збереження максимумів
            Stack<double> maxValues = new();

            // Вибираємо пари та обчислюємо максимум для кожної
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Пара {i + 1}: ({numbers[i]}, {numbers[2 * n - i - 1]})");
                double maxPair = Math.Max(numbers[i], numbers[2 * n - i - 1]); // Обчислюємо максимум для пари
                Console.WriteLine($"Максимум пари {i + 1}: {maxPair}");
                maxValues.Push(maxPair); // Додаємо максимум у стек
            }

            // Знаходимо мінімум серед максимумів
            double result = double.MaxValue;
            while (maxValues.Count > 0)
            {
                Console.Write($"\nМаксимуми пар: {string.Join(", ", maxValues)}");
                double currentMax = maxValues.Pop();
                if (currentMax < result)
                {
                    result = currentMax;
                }
                Console.Write($"; мінімум: {result}");
            }

            // Виведення результату
            Console.WriteLine("\nРезультат: " + result);

            Console.WriteLine("Натисніть довільну клавішу, щоб продовжити.");
            Console.ReadKey();
            Switcher();

        }
        public static void MiniMaxInit()
        {
            // Введення n (кількість пар)
            Console.Write("Введіть значення n (кількість пар): ");
            int n = int.Parse(Console.ReadLine());

            // Введення послідовності чисел
            Console.Write($"Введіть {2 * n} дійсних чисел через пробіл: ");
            double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            // Перевірка коректності введеної кількості чисел
            if (numbers.Length != 2 * n)
            {
                Console.WriteLine("Неправильна кількість чисел!");
                MiniMaxInit();
            }
            else
            {
                MinSearch(n, numbers);
            }
        }
    }
}