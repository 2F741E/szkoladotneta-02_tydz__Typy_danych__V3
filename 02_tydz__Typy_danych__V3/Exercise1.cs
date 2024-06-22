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
            string ageText;
            double age;
            char gender;
            string genderText = "kobieta";
            string peselText = "00000000000";
            long pesel;
            string employeeText;
            uint employeeNumber;
            bool isCorectType;

            bool game = true;
            Console.CursorVisible = true;
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
                Console.WriteLine();
                Console.WriteLine("Proszę o podanie następujących danych:");
                Console.WriteLine();
                Console.Write("imię \t\t");
                firstName = Console.ReadLine();
                Console.Write("nazwisko \t");
                surName = Console.ReadLine();
                do
                {
                    Console.Write("wiek: \t\t");
                    ageText = Console.ReadLine();
                    isCorectType = double.TryParse(ageText, out age);
                    if (!isCorectType || age <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podany wiek pracownika jest nieprawidłowy");
                        Console.WriteLine("Wiek pracownika jest liczbą większą od zera");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (!isCorectType || age <= 0);

                do
                {
                    Console.Write("płeć (k/m) \t");
                    //gender = Char.Parse(Console.ReadLine());
                    gender = Console.ReadKey().KeyChar;
                    if (gender != 'k' && gender != 'm' && gender != 'K' && gender != 'M')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podana płeć pracownika jest nieprawidłowa.");
                        Console.WriteLine("Wybierz k dla kobiety, m dla mężczyzny");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (gender != 'k' && gender != 'm' && gender != 'K' && gender != 'M');
                if (gender != 'k' && gender != 'K')
                {
                    genderText = "mężczyzna";
                }
                do
                {
                    Console.Write("PESEL \t\t");
                    peselText = Console.ReadLine();
                    isCorectType = long.TryParse(peselText, out pesel);
                    if (!isCorectType || pesel < 0 || peselText.Length != 11)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podany PESEL pracownika jest nieprawidłowy.");
                        Console.WriteLine("PESEL powinien zawierać 11 cyfr od 0 do 9");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (!isCorectType || pesel < 0 || peselText.Length != 11);
                do
                {
                    Console.Write("nr pracownika \t");
                    employeeText = Console.ReadLine();
                    isCorectType = uint.TryParse(employeeText, out employeeNumber);
                    if (!isCorectType || employeeNumber <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podany nr pracownika jest nieprawidłowy.");
                        Console.WriteLine("Nr pracownika powinien być dodatni");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (!isCorectType || employeeNumber <= 0);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Dane pracownika:");
                Console.WriteLine();
                Console.WriteLine($"imię: \t\t{firstName}");
                Console.WriteLine($"nazwisko: \t{surName}");
                Console.WriteLine($"wiek: \t\t{age}");
                Console.WriteLine($"płeć: \t\t{genderText}");
                Console.WriteLine($"PESEL: \t\t{peselText}");
                Console.WriteLine($"nr pracownika: \t{employeeNumber}");
                Console.WriteLine();

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
    }
}
