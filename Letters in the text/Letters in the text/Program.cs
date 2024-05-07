using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (char letter in text.ToLower())
        {
            if (Char.IsLetter(letter))
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount[letter] = 1;
                }
            }
        }

        foreach (KeyValuePair<char, int> pair in letterCount)
        {
            Console.WriteLine($"Буква: {pair.Key}, Количество: {pair.Value}");
        }
        Console.ReadKey();
    }
}
