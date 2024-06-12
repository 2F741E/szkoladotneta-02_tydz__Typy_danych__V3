
using Microsoft.VisualBasic;

namespace _02_tydz__Typy_danych__V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ArrowRight = "" + Strings.ChrW(8594);
            int cursorPosition = 1;
            bool game = true;

            //Menu.MainMenu();
            //Menu.CursorPosition(cursorPosition + 1, ArrowRight);
            //Console.WriteLine("x");

            //Console.Clear();
            //Console.WriteLine("Widoczność kursora: " + Console.CursorVisible);
            //Console.ReadLine();
            Console.CursorVisible = false;

            do
            {
                Menu.MainMenu();
                Menu.CursorPosition(cursorPosition + 1, ArrowRight);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.DownArrow:
                        if (cursorPosition < 5)
                        {
                            Menu.CursorPosition(cursorPosition + 1, " ");
                            cursorPosition++;
                            Menu.CursorPosition(cursorPosition + 1, ArrowRight);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (cursorPosition > 1)
                        {
                            Menu.CursorPosition(cursorPosition + 1, " ");
                            cursorPosition--;
                            Menu.CursorPosition(cursorPosition + 1, ArrowRight);
                        }
                        break;
                    case ConsoleKey.Enter:
                        Menu.ExerciseNr(cursorPosition);
                        break;
                    case ConsoleKey.Escape:
                        game = false;
                        Console.Write("x");
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
            }
            while (game);
            //Console.Clear();
            //Console.SetCursorPosition(12, 12);
            Console.SetCursorPosition(0, 12);

            //Console.WriteLine(" ");
            //Console.Write("k");
            Console.WriteLine("Koniec");
            Console.WriteLine();

            Console.CursorVisible = true;
        }
    }
}
