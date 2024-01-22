using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите исходную температурную шкалу:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");

        char sourceScale = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Переход на новую строку

        Console.Write("Введите температуру: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите целевую температурную шкалу:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");

        char targetScale = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Переход на новую строку

        // Выполнение конвертации и вывод результата
        double convertedTemperature = ConvertTemperature(temperature, sourceScale, targetScale);
        Console.WriteLine($"Результат конвертации: {convertedTemperature} градусов");

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static double ConvertTemperature(double temperature, char sourceScale, char targetScale)
    {
        double result = 0;

        switch (sourceScale)
        {
            case '1': // Цельсий
                switch (targetScale)
                {
                    case '1':
                        result = temperature; // Цельсий в Цельсии
                        break;
                    case '2':
                        result = temperature + 273.15; // Цельсий в Кельвинах
                        break;
                    case '3':
                        result = (temperature * 9 / 5) + 32; // Цельсий в Фаренгейтах
                        break;
                }
                break;

            case '2': // Кельвин
                switch (targetScale)
                {
                    case '1':
                        result = temperature - 273.15; // Кельвины в Цельсии
                        break;
                    case '2':
                        result = temperature; // Кельвины в Кельвинах
                        break;
                    case '3':
                        result = (temperature - 273.15) * 9 / 5 + 32; // Кельвины в Фаренгейтах
                        break;
                }
                break;

            case '3': // Фаренгейт
                switch (targetScale)
                {
                    case '1':
                        result = (temperature - 32) * 5 / 9; // Фаренгейты в Цельсии
                        break;
                    case '2':
                        result = (temperature - 32) * 5 / 9 + 273.15; // Фаренгейты в Кельвинах
                        break;
                    case '3':
                        result = temperature; // Фаренгейты в Фаренгейтах
                        break;
                }
                break;

            default:
                Console.WriteLine("Ошибка: Неверная шкала температуры.");
                break;
        }

        return result;
    }
}
