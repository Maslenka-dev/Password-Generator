using System;
using System.Globalization;

namespace GenerationPassword
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Generate generate = new Generate();

            Console.WriteLine("Какой длины пароль вы хотите?");
            int LengthOfPassword = int.Parse(Console.ReadLine());
            int NumberEqualsNum = LengthOfPassword;
            int Division = NumberEqualsNum /= 3;
            //Console.WriteLine($"Division: {Division}");
            int Remainder = LengthOfPassword %= 3;
            //Console.WriteLine($"Remainder: {Remainder}");

            int NumberOfSymbols = Division;
            int NumberOfNumbers = Division;
            int NumberOfLetters = Division;

            int[] ArrayOfValues = new int[3];
            int RandomFromArrayOfValues = rnd.Next(ArrayOfValues.Length);
            switch (RandomFromArrayOfValues)
            {
                case 0:
                    NumberOfSymbols += Remainder;
                    break;
                case 1:
                    NumberOfNumbers += Remainder;
                    break;
                case 2:
                    NumberOfLetters += Remainder;
                    break;
            }

            while (true)
            {
                if (NumberOfSymbols == 0 && NumberOfNumbers == 0 && NumberOfLetters == 0)
                {
                    break;
                }
                int RandomNumberInArray = rnd.Next(ArrayOfValues.Length);
                if (RandomNumberInArray == 0 && NumberOfSymbols > 0)
                {
                    NumberOfSymbols--;
                    generate.GenerateSymbol();
                }
                else if (RandomNumberInArray == 1 && NumberOfNumbers > 0)
                {
                    NumberOfNumbers--;
                    generate.GenerateNumber();
                }
                else if (RandomNumberInArray == 2 && NumberOfLetters > 0)
                {
                    NumberOfLetters--;
                    generate.GenerateLetter();
                }
            }
            Console.Read();
        }
    }
    class Generate
    {
        Random rnd = new Random();
        public void GenerateNumber()
        {
            int[] numbers = new int[10];
            Console.Write(rnd.Next(numbers.Length));
        }
        public void GenerateLetter()
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 't', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int i = rnd.Next(letters.Length);
            Console.Write(letters[i]);
        }
        public void GenerateSymbol()
        {
            char[] symbols = { '~', '`', '!', '@', '"', '№', '#', '$', ';', '%', ':', '^' , '&', '?', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '|', '/', '"', ':', ';', ',', '.', '<', '>'};
            int i = rnd.Next(symbols.Length);
            Console.Write(symbols[i]);
        }
    }
}
