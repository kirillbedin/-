using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество уровней пирамиды: ");
        int levels = Convert.ToInt32(Console.ReadLine());

        // Вывод пирамиды
        PrintPyramid(levels);

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static void PrintPyramid(int levels)
    {
        for (int i = 1; i <= levels; i++)
        {
            // Вывод пробелов перед числами для выравнивания
            for (int j = 0; j < levels - i; j++)
            {
                Console.Write("  ");
            }

            // Вывод чисел в убывающем порядке
            for (int k = i; k >= 1; k--)
            {
                Console.Write($"{k} ");
            }

            // Вывод чисел в возрастающем порядке (без повторения 1)
            for (int l = 2; l <= i; l++)
            {
                Console.Write($"{l} ");
            }

            Console.WriteLine(); // Переход на новую строку после каждого уровня
        }
    }
}
