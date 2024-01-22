using System;

class Program
{
    static void Main()
    {
        // Ввод размерности массивов
        Console.Write("Введите размерность массивов: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Ввод значений для первого массива
        double[] array1 = InputArrayValues(size, "Первый");

        // Ввод значений для второго массива
        double[] array2 = InputArrayValues(size, "Второй");

        // Перемножение массивов
        double[] resultArray = MultiplyArrays(array1, array2);

        // Вывод результата
        Console.WriteLine("Результат перемножения массивов:");
        PrintArray(resultArray);

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static double[] InputArrayValues(int size, string arrayName)
    {
        Console.WriteLine($"Введите значения для {arrayName} массива:");

        double[] array = new double[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{arrayName}[{i}]: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        return array;
    }

    static double[] MultiplyArrays(double[] array1, double[] array2)
    {
        int size = Math.Min(array1.Length, array2.Length);
        double[] resultArray = new double[size];

        for (int i = 0; i < size; i++)
        {
            // Перемножаем соответствующие элементы массивов
            resultArray[i] = array1[i] * array2[i];
        }

        return resultArray;
    }

    static void PrintArray(double[] array)
    {
        foreach (var value in array)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine();
    }
}
