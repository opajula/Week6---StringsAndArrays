using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "dont panic" nulliga - 0;
            //programm asendab kõik 'a' tähed samas lauses numbriga 4

            string DP = "Don't panic!";

            DP = DP.Replace('o', '0');
            DP = DP.Replace('a', '4');

            Console.WriteLine(DP);
        }
    }
}
