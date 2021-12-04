using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello world!"


            Console.WriteLine("Hello World!");
            Console.WriteLine("Kui mitu 'h', 'o' ja 'l' tähte on selles lauses?");
            string HelloWorld = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'h')
                {
                    hCounter++;
                }
            }

            if (hCounter == 1)
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' täht. ");
            }
            else
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' tähte. ");
            }

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'o')
                {
                    oCounter++;
                }
            }

            if (oCounter == 1)
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' täht. ");
            }
            else
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' tähte. ");
            }

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }

            if (lCounter == 1)
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' täht. ");
            }
            else
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' tähte. ");
            }
        }
    }
}
