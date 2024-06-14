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

                // początek zadania
                Console.WriteLine("Program prosi użytkownika o jego dane personalne tj.");
                Console.WriteLine("imię, nazwisko,numer telefonu, adres email, wzrost, waga (np. 85,7), itp.");
                Console.WriteLine("imię, nazwisko,numer telefonu, adres email, wzrost, waga (np. 85,7), itp.");
                Console.WriteLine("Odpowiedź jest przekonwertowana do odpowiedniego typu danych");
                Console.WriteLine("z użyciem metody: typDanych.Parse(odpowiedźOdUżytkownika).");
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

        private static void Announcement(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text + " , spróbuj powtórnie");
            Console.WriteLine();
        }
    }
}
