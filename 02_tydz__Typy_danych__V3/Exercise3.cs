using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Exercise3
    {
        public static void Start()
        {
            double lenght, width, diagonal;
            bool isCorectType;

            bool game = true;
            Console.CursorVisible = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 3");
                Console.WriteLine();

                // początek zadania
                Console.WriteLine("Program na podstawie podanej szerokości i długości prostokąta");
                Console.WriteLine("wylicza długość przekątnej.");
                Console.WriteLine("Do obliczenia kwadratu liczby użyto metody Math.Pow())");

                Console.WriteLine();
                Console.WriteLine("Proszę o podanie wymiarów prostokąta:");
                Console.WriteLine();
                do
                {
                    Console.Write("szerokość: \t");
                    isCorectType = double.TryParse(Console.ReadLine(), out width);
                    if (!isCorectType)
                    {
                        Announcement("To nie jest poprawna liczba");
                    }
                    if (width < 0)
                    {
                        Announcement("Szerokość nie może być liczbą ujemną");
                    }
                }
                while (!isCorectType || width < 0);
                do
                {
                    Console.Write("długość: \t");
                    isCorectType = double.TryParse(Console.ReadLine(), out lenght);
                    if (!isCorectType)
                    {
                        Announcement("To nie jest poprawna liczba");
                    }
                    if (lenght < 0)
                    {
                        Announcement("Długość nie może być liczbą ujemną");
                    }
                }
                while (!isCorectType || lenght < 0);

                diagonal = Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(width, 2));

                Console.WriteLine();
                Console.WriteLine($"przekątna prostokąta wynosi {diagonal}");

                // koniec zadania

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ESC or DELETE or END - powrót do menu głównego");
                Console.WriteLine("(inny klawisz        - ponowny start zadania)");

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
            Console.CursorVisible = false;
        }

        private static void Announcement(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text + " , spróbuj powtórnie");
            Console.WriteLine();
        }
    }
}
