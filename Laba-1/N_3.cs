using System;

class Program
{
    static void Main()
    {
        string sentence = "Це приклад речення для тестування";
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if ((i + 1) % 2 != 0) // перевіряємо непарність номера слова
            {
                Console.WriteLine("Слово: " + words[i] + ", Кількість букв: " + words[i].Length);
            }
        }
    }
}

