using System.Collections.Concurrent;

namespace diary_
{
    internal class Program
    {
        public static void Arrows()
        {
            notes note_1 = new notes();
            notes note_2 = new notes();
            notes note_3 = new notes();
            notes note_4 = new notes();
            notes note_5 = new notes();
            notes[] allNotes = new notes[] { note_1, note_2, note_3, note_4, note_5 };
            allNotes[0].date = new DateOnly (2022, 10, 22);
            allNotes[0].name = "сходить в магазин";
            allNotes[0].description = "купить молоко и хлеб";
            allNotes[0].i = 1;
            allNotes[1].date = new DateOnly(2022, 10, 22);
            allNotes[1].name = "сделать практическую";
            allNotes[1].description = "ОАИП C#";
            allNotes[1].i = 2;
            allNotes[2].date = new DateOnly(2022, 10, 26);
            allNotes[2].name = "сходить погулять";
            allNotes[2].description = "сегодня в 18:00";
            allNotes[2].i = 1;
            allNotes[3].date = new DateOnly(2022, 10, 26);
            allNotes[3].name = "купить подарок другу";
            allNotes[3].description = "скоро день рождения друга";
            allNotes[3].i = 2;
            allNotes[4].date = new DateOnly(2022, 10, 29);
            allNotes[4].name = "поиграть в компьютер";
            allNotes[4].description = "точнее в доту";
            allNotes[4].i = 1;
            var date = new DateOnly(2022, 10, 20);
            Console.WriteLine("дата: " + date);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            ConsoleKeyInfo move = Console.ReadKey();
            int y = 0;
            while (move.Key != ConsoleKey.Escape)
            {
                if (move.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, y++);
                    Console.WriteLine("->");
                }
                else if (move.Key == ConsoleKey.UpArrow)
                {
                    if (y == 1)
                    {

                    }
                    else
                    {
                        Console.SetCursorPosition(0, y--);
                        Console.WriteLine("->");
                    }
                }
                else if (move.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(+1);
                    y = 1;
                }
                else if (move.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                    y = 1;
                }
                Console.Clear();
                Console.WriteLine("дата: " + date);
                Console.SetCursorPosition(0, y);
                Console.Write("->");
                if (date == allNotes[0].date && date == allNotes[1].date)
                {
                    Console.SetCursorPosition(2, allNotes[0].i);
                    Console.WriteLine("  " + allNotes[0].name);
                    Console.SetCursorPosition(2, allNotes[1].i);
                    Console.WriteLine("  " + allNotes[1].name);
                    if (move.Key == ConsoleKey.Enter && y == allNotes[0].i)
                    {
                        Console.Clear();
                        Console.WriteLine(allNotes[0].date);
                        Console.WriteLine(allNotes[0].description);
                    } else if (move.Key == ConsoleKey.Enter && y == allNotes[1].i)
                    {
                        Console.Clear();
                        Console.WriteLine(allNotes[1].date);
                        Console.WriteLine(allNotes[1].description);
                    }
                }
                if (date == allNotes[2].date && date == allNotes[3].date)
                {
                    Console.SetCursorPosition(2, allNotes[2].i);
                    Console.WriteLine("  " + allNotes[2].name);
                    Console.SetCursorPosition(2, allNotes[3].i);
                    Console.WriteLine("  " + allNotes[3].name);
                    if (move.Key == ConsoleKey.Enter && y == allNotes[2].i)
                    {
                        Console.Clear();
                        Console.WriteLine(allNotes[2].date);
                        Console.WriteLine(allNotes[2].description);
                    }
                    else if (move.Key == ConsoleKey.Enter && y == allNotes[3].i)
                    {
                        Console.Clear();
                        Console.WriteLine(allNotes[3].date);
                        Console.WriteLine(allNotes[3].description);
                    }
                }
                if (date == allNotes[4].date)
                {
                    Console.SetCursorPosition(2, allNotes[4].i);
                    Console.WriteLine("  " + allNotes[4].name);
                    if (move.Key == ConsoleKey.Enter && y == allNotes[4].i)
                    {
                        Console.Clear();
                        Console.WriteLine(allNotes[4].date);
                        Console.WriteLine(allNotes[4].description);
                    }
                }
                move = Console.ReadKey();
            }
        }

        static void Main()
        {
            Arrows();
        }
    }
}