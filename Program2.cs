using System;

class Program
{
    static void Main()
    {
        // Ввод чисел с клавиатуры
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите третье число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите четвертое число: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        // Нахождение среднего значения
        double average = FindAverage(num1, num2, num3, num4);

        // Вывод результата
        Console.WriteLine($"Среднее значение: {average}");

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static double FindAverage(double num1, double num2, double num3, double num4)
    {
        double total = num1 + num2 + num3 + num4;
        double average = total / 4;
        return average;
    }
}
