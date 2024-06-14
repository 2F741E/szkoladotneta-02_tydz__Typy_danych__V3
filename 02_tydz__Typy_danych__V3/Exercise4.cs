using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Exercise4
    {
        public static void Start()
        {
            bool game = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 4");
                Console.WriteLine();

                // początek zadania
                Console.WriteLine("Program tworzy 2 zmienne liczbowe oraz jedną tekstową, o poprawnych typach danych");
                Console.WriteLine("a następnie przypisuje im następujące wartości:");
                Console.WriteLine("a. 10");
                Console.WriteLine("b. Szkoła Dotneta");
                Console.WriteLine("c. 12,5");
                Console.WriteLine();
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
