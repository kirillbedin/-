using System;

class Program
{
    static void Main()
    {
        // Ввод пяти чисел
        double[] numbers = InputNumbers(5);

        // Нахождение максимального и минимального числа
        double maxNumber = FindMaxNumber(numbers);
        double minNumber = FindMinNumber(numbers);

        // Вывод результатов
        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static double[] InputNumbers(int count)
    {
        Console.WriteLine($"Введите {count} чисел:");

        double[] numbers = new double[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        return numbers;
    }

    static double FindMaxNumber(double[] numbers)
    {
        double maxNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        return maxNumber;
    }

    static double FindMinNumber(double[] numbers)
    {
        double minNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        return minNumber;
    }
}
