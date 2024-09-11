using System;

class Program
{
    static void Main()
    {
        string sentence = "Це приклад речення для тестування";
        string[] words = sentence.Split(' ');

        if (words.Length >= 2)
        {
            // міняємо перше і друге слова місцями
            string temp = words[0];
            words[0] = words[1];
            words[1] = temp;
        }

        string result = string.Join(" ", words);
        Console.WriteLine("Нове речення: " + result);
    }
}

