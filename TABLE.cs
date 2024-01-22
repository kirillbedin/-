using System;

class Program
{
    static void Main()
    {
        PrintMultiplicationTable();

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static void PrintMultiplicationTable()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i} х {j} = {i * j}\t");
            }
            Console.WriteLine();
        }
    }
}
