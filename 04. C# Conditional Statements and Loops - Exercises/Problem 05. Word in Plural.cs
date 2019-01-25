using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string lastLetter = word[word.Length - 1].ToString();
            switch (lastLetter)
            {
                case "y":
                    string newWord = string.Empty;
                    for (int i = 0; i < word.Length-1; i++)
                    {
                        newWord += word[i];
                    }
                    newWord += "ies";
                    word = newWord;
                    break;
                case "o":
                case "s":
                case "x":
                case "z":
                    word += "es";
                    break;
                case "h":
                    if (word[word.Length-2].ToString() == "c" || word[word.Length - 2].ToString() == "s")
                    {
                        word += "es";
                    }
                    break;
                default:
                    word += "s";
                    break;
            }

            Console.WriteLine(word);

        }
    }
}
