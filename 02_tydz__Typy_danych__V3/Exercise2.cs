using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Exercise2
    {
        public static void Start()
        {
            bool game = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 2");
                Console.WriteLine();

                // początek zadania
                Console.WriteLine("Program, który tworzy 3 zmienne z jedną literą,");
                Console.WriteLine("a następnie wypisuje je w odwrotnej kolejności niż zostały zadeklarowane");

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

        private static void Announcement(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text + " , spróbuj powtórnie");
            Console.WriteLine();
        }
    }
}
