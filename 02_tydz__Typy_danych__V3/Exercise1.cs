using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Exercise1
    {
        public static void Start()
        {
            string firstName, surName;
            int age;
            char gender;
            long pesel;
            double employeeNumber;
            char controlGame;
            bool isCorectType;

            bool game = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 1");
                Console.WriteLine();

                // początek zadania
                Console.WriteLine("Program deklaruje zmienne odpowiednich typów dotyczące danych pracownika firmy.");
                Console.WriteLine("Dane, które są przetrzymywane to:");
                Console.WriteLine("a. Imię,");
                Console.WriteLine("b. Nazwisko,");
                Console.WriteLine("c. Wiek,");
                Console.WriteLine("d. Płeć (‘m’ albo ‘k’)");
                Console.WriteLine("e. PESEL");
                Console.WriteLine("f. Numer pracownika (np. 2509324094)");

                Console.Clear();
                Console.WriteLine("Proszę o podanie następujących danych:");
                Console.WriteLine();
                Console.Write("imię \t\t");
                firstName = Console.ReadLine();
                Console.Write("nazwisko \t");
                surName = Console.ReadLine();
                do
                {
                    Console.Write("wiek: \t\t");
                    isCorectType = Int32.TryParse(Console.ReadLine(), out age);
                    if (!isCorectType)
                    {
                        Announcement("Podany wiek");
                    }
                }
                while (!isCorectType);

                do
                {
                    Console.Write("płeć (k/m) \t");
                    gender = Char.Parse(Console.ReadLine());
                    if (gender != 'k' && gender != 'm' && gender != 'K' && gender != 'M')
                    {
                        Announcement("Podana płeć");
                    }

                }
                while (gender != 'k' && gender != 'm' && gender != 'K' && gender != 'M');
                do
                {
                    Console.Write("PESEL \t\t");
                    isCorectType = long.TryParse(Console.ReadLine(), out pesel);
                    if (!isCorectType)
                    {
                        Announcement("Podany nr pesel");
                    }
                }
                while (!isCorectType);
                do
                {
                    Console.Write("nr pracownika \t");
                    isCorectType = Double.TryParse(Console.ReadLine(), out employeeNumber);
                    if (!isCorectType)
                    {
                        Announcement("Podany nr pracownika");
                    }
                }
                while (!isCorectType);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Dane pracownika:");
                Console.WriteLine();
                Console.WriteLine($"imię: \t\t{firstName}");
                Console.WriteLine($"nazwisko: \t{surName}");
                Console.WriteLine($"wiek: \t\t{age} lat");
                Console.WriteLine($"płeć: \t\t{gender} (k - kobieta, m - mężczyzna)");
                Console.WriteLine($"PESEL: \t\t{pesel}");
                Console.WriteLine($"nr pracownika: \t{employeeNumber}");
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
            Console.WriteLine(text + " jest niepoprawny, spróbuj powtórnie");
            Console.WriteLine();
        }
        
    }
}
