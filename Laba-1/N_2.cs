class Program
{
    static void Main()
    {
        string input = "абпаваа";
        char firstChar = input[0];
        string result = input.Replace(firstChar.ToString(), "");
        Console.WriteLine("Рядок після видалення першого символу: " + result);
    }
}

