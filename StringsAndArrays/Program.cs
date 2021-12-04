using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt tema eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisestage oma eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");



        }
    }
}
