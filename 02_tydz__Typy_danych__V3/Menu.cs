using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_tydz__Typy_danych__V3
{
    public class Menu
    {
        public string ArrowRight = "" + Strings.ChrW(8594);
        public static void MainMenu()
        {

            Console.Clear();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Typy danych");
            Console.WriteLine();
            Console.WriteLine("  1. Deklaracja zmiennych dot. danych pracownika firmy");
            Console.WriteLine("  2. Deklaracja 3 jednoliterowych zmiennych i wypisanie w odwrotnej kolejności ich deklaracji");
            Console.WriteLine("  3. Obliczanie przekątnej prostokąta");
            Console.WriteLine("  4. Tworzenie 2 zmiennych liczbowych i jednej tekstowej a następnie przypisanie im wartości");
            Console.WriteLine("  5. Dane personalne użytkownika");
            Console.WriteLine();
            Console.WriteLine("Choose - Arrow Up (" + Strings.ChrW(8593) + "), Arrow Down (" + Strings.ChrW(8595) + ")");
            Console.WriteLine("Accept - Enter (" + Strings.ChrW(8626) + ")");
            Console.WriteLine("Finish - Esc or Delete or End");
        }

        public static void CursorPosition(int position, string txt)
        {

            Console.SetCursorPosition(0, position);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write(txt);
            Console.SetCursorPosition(0, 11);
        }

        public static void ExerciseNr(int nr)
        {
            switch (nr)
            {
                case 1:
                    Exercise1.Start();
                    break;
                case 2:
                    Exercise2.Start();
                    break;
                case 3:
                    Exercise3.Start();
                    break;
                case 4:
                    Exercise4.Start();
                    break;
                case 5:
                    Exercise5.Start();
                    break;
                default:
                    break;

            }
        }
    }
}
