using System;

namespace PoC___Caesar
{
    class Program
    {
        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv det du vill kryptera:");
            string UserString = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Skriv in din nyckel: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("Krypterad data");
            string cipherText = Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Okrypterad data");
            string t = Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

            Console.WriteLine("Tryck valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}
