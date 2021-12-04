using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime;
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem: ees v pere

            Console.WriteLine("Sisestage oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisestage oma perekonnanimi:");
            string lastName = Console.ReadLine();

            if(firstName.Length < lastName.Length)
            {
                Console.WriteLine($"Sinu eesnimi ({firstName.Length} sümbolit) on lühem kui perekonnanimi ({lastName.Length} sümbolit).");
            }
            else if(firstName.Length > lastName.Length)
            {
                Console.WriteLine($"Sinu eesnimi ({firstName.Length} sümbolit) on pikem kui perekonnanimi ({lastName.Length} sümbolit).");
            }
            else
            {
                Console.WriteLine($"Sinu ees- ja perekonnanimi on täpelt sama pikad! Eesnimes on {firstName.Length} sümbolit ning perekonnanimes on samuti {lastName.Length} sümbolit.");
            }

            
        }
    }
}
