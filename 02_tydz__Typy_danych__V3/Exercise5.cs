using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Exercise5
    {
        public static void Start()
        {
            bool game = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 5");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ESC or DELETE or END - powrót do menu głównego");
                Console.WriteLine("(inny klawisz        - ponowny start programu)");

                //if (Console.ReadKey().Key == ConsoleKey.Escape || Console.ReadKey().Key == ConsoleKey.Delete || Console.ReadKey().Key == ConsoleKey.End)
                //{
                //   game = false;
                //}

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
