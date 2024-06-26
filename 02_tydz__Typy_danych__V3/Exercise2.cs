﻿using System;
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
            Console.CursorVisible = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 2");
                Console.WriteLine();

                Console.WriteLine("Program tworzy 3 zmienne z jedną literą,");
                Console.WriteLine("a następnie wypisuje je w odwrotnej kolejności niż zostały zadeklarowane");
                Console.WriteLine();
                Console.WriteLine("podaj wartości trzech poniżej podanych zmiennych:");
                Console.WriteLine();

                // początek zadania
                Console.Write("a = ");
                string a = Console.ReadLine();
                Console.Write("b = ");
                string b = Console.ReadLine();
                Console.Write("c = ");
                string c = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Oto 3 zmienne wyświetlone w odwrotnej kolejności niż zostały zadeklarowane i wczytane");
                Console.WriteLine();
                Console.WriteLine($"zmienna c: {c}");
                Console.WriteLine($"zmienna b: {b}");
                Console.WriteLine($"zmienna a: {a}");
                Console.WriteLine();
                // koniec zadania

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
