using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string sentence = Console.ReadLine();

        // Используем метод Split для разделения предложения на слова
        string[] words = sentence.Split(' ');

        // Находим самое длинное слово
        string longestWord = FindLongestWord(words);

        if (longestWord != null)
        {
            Console.WriteLine($"Самое длинное слово: {longestWord}");
        }
        else
        {
            Console.WriteLine("Ошибка: Пустое предложение.");
        }

        // Ожидание пользовательского ввода перед завершением программы
        Console.ReadLine();
    }

    static string FindLongestWord(string[] words)
    {
        if (words.Length == 0)
        {
            return null;
        }

        string longestWord = words[0];

        foreach (string word in words)
        {
            // Убираем знаки препинания, если они есть
            string cleanedWord = RemovePunctuation(word);

            if (cleanedWord.Length > longestWord.Length)
            {
                longestWord = cleanedWord;
            }
        }

        return longestWord;
    }

    static string RemovePunctuation(string word)
    {
        // Удаляем знаки препинания из слова
        string cleanedWord = new string(word.Where(c => Char.IsLetter(c) || Char.IsDigit(c) || Char.IsWhiteSpace(c)).ToArray());
        return cleanedWord;
    }
}
