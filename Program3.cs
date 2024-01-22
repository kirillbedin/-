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

        // Выбор операции
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");

        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Переход на новую строку

        // Выполнение выбранной операции и вывод результата
        double result = PerformOperation(num1, num2, operation);
        Console.WriteLine($"Результат операции: {result}");

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static double PerformOperation(double num1, double num2, char operation)
    {
        double result = 0;

        switch (operation)
        {
            case '1':
                result = num1 + num2;
                break;
            case '2':
                result = num1 - num2;
                break;
            case '3':
                result = num1 * num2;
                break;
            case '4':
                // Проверка деления на ноль
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Ошибка: Нельзя делить на ноль.");
                break;
            default:
                Console.WriteLine("Ошибка: Неверная операция.");
                break;
        }

        return result;
    }
}
