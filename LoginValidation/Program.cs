using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisustatud PIN-koodi arvuga 1234
            //kui sisestatud PIN.kood on 1234
            //programm kuvab konsoolis "Tere tulemast"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti!"
            //kasutajal on 3 katset
            //kt: admin, pr:admin1234
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool:");
                string password = Console.ReadLine();
                if (userName != "admin" || password != "admin1234")
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} Proovi uuesti!");
                }
                else
                {
                    Console.WriteLine("Tere tulemast");
                }
            }
        }
    }
}
