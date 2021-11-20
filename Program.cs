using System;

namespace PoC___Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "";

            System.Console.WriteLine("Ange text du vill kryptera:");
            string okrypteradText = Console.ReadLine();

            Console.WriteLine("Hur många steg vill du förskjuta?");
            var steps = Console.ReadLine();

            for (int i = 0; i <= okrypteradText.Length; i++)
            {
                char omvandladOkrypteradText = okrypteradText[i];

                //TODO:
                /*
                if (Char.IsUpper(omvandladOkrypteradText))
                {
                    result += omvandladOkrypteradText(( + steps-65) % 26 + 65);
                }
                else
                {
                    result += omvandladOkrypteradText(( + steps-97) % 26 + 97);
                }
                return result;
                */
            }
        }
    }
}
