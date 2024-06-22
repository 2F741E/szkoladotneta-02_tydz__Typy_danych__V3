using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Exercise5
    {
        public static void Start()
        {
            string firstName, surName, eyesColour, nationality, citizenship;
            string ageText;
            double age;
            string genderText = "kobieta";
            char gender;
            string peselText = "00000000000";
            long pesel;
            string weightText, growthText;
            double weight, growth;
            bool isCorectType;

            bool game = true;
            Console.CursorVisible = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Zadanie 5");
                Console.WriteLine();

                Console.WriteLine("Program pobiera dane osobowe.");
                Console.WriteLine("Dane, o które zwraca się program to:");
                Console.WriteLine("a. Imię,");
                Console.WriteLine("b. Nazwisko,");
                Console.WriteLine("c. Płeć (‘m’ albo ‘k’),");
                Console.WriteLine("d. Narodowość");
                Console.WriteLine("e. Obywatelstwo");
                Console.WriteLine("f. Wiek");
                Console.WriteLine("g. PESEL");
                Console.WriteLine("h. Waga");
                Console.WriteLine("i. Wzrost");
                Console.WriteLine("j. Kolor oczu");
                Console.WriteLine();
                Console.WriteLine("Proszę o podanie danych personalnych");
                Console.WriteLine();

                // początek zadania
                Console.Write("imię \t\t");
                firstName = Console.ReadLine();
                Console.Write("nazwisko \t");
                surName = Console.ReadLine();
                do
                {
                    Console.Write("płeć (k/m) \t\t");
                    //isCorectType = Char.TryParse(Console.ReadLine(), out gender);
                    gender = Console.ReadKey().KeyChar;
                    if (gender != 'k' && gender != 'm' && gender != 'K' && gender != 'M')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podana płeć osoby jest nieprawidłowa.");
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
                Console.Write("narodowość \t");
                nationality = Console.ReadLine();
                Console.Write("obywatelstwo \t");
                citizenship = Console.ReadLine();
                do
                {
                    Console.Write("wiek: \t\t");
                    ageText = Console.ReadLine();
                    isCorectType = double.TryParse(ageText, out age);
                    if (!isCorectType || age <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podany wiek osoby jest nieprawidłowy");
                        Console.WriteLine("Wiek osoby jest liczbą większą od zera");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (!isCorectType || age <= 0);
                do
                {
                    Console.Write("PESEL \t\t");
                    peselText = Console.ReadLine();
                    isCorectType = long.TryParse(peselText, out pesel);
                    if (!isCorectType || pesel < 0 || peselText.Length != 11)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podany PESEL osoby jest nieprawidłowy.");
                        Console.WriteLine("PESEL osoby zawierać 11 cyfr od 0 do 9");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (!isCorectType || pesel < 0 || peselText.Length != 11);

                do
                {
                    Console.Write("waga: \t\t");
                    weightText = Console.ReadLine();
                    isCorectType = double.TryParse(weightText, out weight);
                    if (!isCorectType || weight <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podana waga osoby jest nieprawidłowa");
                        Console.WriteLine("Wiek osoby jest liczbą większą od zera");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (!isCorectType || weight <= 0);
                do
                {
                    Console.Write("wzrost: \t\t");
                    growthText = Console.ReadLine();
                    isCorectType = double.TryParse(growthText, out growth);
                    if (!isCorectType || growth <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Podany wzrost osoby jest nieprawidłowy");
                        Console.WriteLine("Wzrost osoby jest liczbą większą od zera");
                        Console.WriteLine("spróbuj ponownie");
                        Console.WriteLine();
                    }
                }
                while (!isCorectType || growth <= 0);
                Console.Write("kolor oczu \t");
                eyesColour = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Twoje dane osobowe:");
                Console.WriteLine();
                Console.WriteLine($"imię: \t\t{firstName}");
                Console.WriteLine($"nazwisko: \t{surName}");
                Console.WriteLine($"płeć: \t\t{gender} (k - kobieta, m - mężczyzna)");
                Console.WriteLine($"narodowość: \t{nationality}");
                Console.WriteLine($"obywatelstwo: \t{citizenship}");
                Console.WriteLine($"wiek: \t\t{age} lat");
                Console.WriteLine($"PESEL: \t\t{pesel}");
                Console.WriteLine($"waga: \t\t{weight}");
                Console.WriteLine($"wzrost: \t{growth}");
                Console.WriteLine($"kolor oczu: \t{eyesColour}");
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
            Console.CursorVisible = false;
        }
    }
}
