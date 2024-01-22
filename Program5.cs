using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Введите путь к файлу: ");
        string filePath = Console.ReadLine();

        // Получение имени файла с расширением из пути
        string fileName = GetFileNameFromPath(filePath);

        if (fileName != null)
        {
            Console.WriteLine($"Имя файла: {fileName}");
        }
        else
        {
            Console.WriteLine("Ошибка: Неверный путь к файлу.");
        }

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static string GetFileNameFromPath(string filePath)
    {
        try
        {
            // Используем класс Path для извлечения имени файла из пути
            string fileName = Path.GetFileName(filePath);
            return fileName;
        }
        catch (ArgumentException)
        {
            // Обработка случая, если путь некорректен
            return null;
        }
    }
}
