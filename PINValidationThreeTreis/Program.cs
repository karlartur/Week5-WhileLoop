using System;

namespace PINValidationThreeTreis
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


            int i = 0;
            while (i < 3) 
            {
                Console.WriteLine("Sisesta PIN:");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    //break;
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} Proovi uuesti!");
                   
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
