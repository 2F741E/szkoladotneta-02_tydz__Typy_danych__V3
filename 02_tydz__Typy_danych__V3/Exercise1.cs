using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Exercise1
    {
        public static void Start()
        {
            bool game = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 1");

                // początek zadania
                Console.WriteLine("Program deklaruje zmienne odpowiednich typów dotyczące danych pracownika firmy.");
                Console.WriteLine("Dane, które są przetrzymywane to:");
                Console.WriteLine("a. Imię,");
                Console.WriteLine("b. Nazwisko,");
                Console.WriteLine("c. Wiek,");
                Console.WriteLine("d. Płeć (‘m’ albo ‘k’)");
                Console.WriteLine("e. PESEL");
                Console.WriteLine("f. Numer pracownika (np. 2509324094)");
                

                // koniec zadania

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ESC or DELETE or END - powrót do menu głównego");
                Console.WriteLine("(inny klawisz        - ponowny start programu)");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        game = false;
                        break;
                    case ConsoleKey.Delete:
                        game = false;
                        break;
                    case ConsoleKey.End:
                        game = false;
                        break;
                    default:
                        break;
                }
            } while (game);
        }

    }
}
