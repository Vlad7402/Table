using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int hight = 5;
            int whight = 5;
            int GorisontNum = 11;
            int VertNum= 4;
            int GorisontPass= 10;
            int VertPass = 3;
            TablePrint(hight, whight, GorisontNum, VertNum, GorisontPass, VertPass);
        }
        static void TablePrint(int hight, int whight, int GorisontNum, int VertNum, int GorisontPass, int VertPass)
        {
            VertPassing(VertPass);
            LinePrint(whight, GorisontNum, GorisontPass, "┌", "┬", "┐");
            for (int i = 1; i <= VertNum; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                    GorisontPassing(GorisontPass);
                    WhitespacePrint(whight, GorisontNum, GorisontPass);
                }
                if (i != VertNum) LinePrint(whight, GorisontNum, GorisontPass, "├", "┼", "┤");
            }
            LinePrint(whight, GorisontNum, GorisontPass, "└", "┴", "┘");
            ReColour(1, 1, GorisontPass, VertPass, hight, whight);
        }
        static void GorisontPassing (int GorPass)
        {
            for (int i = 0; i < GorPass; i++)
            {
                Console.Write(" ");
            }
        }
        static void VertPassing(int VertPass)
        {
            for (int i = 0; i < VertPass; i++)
            {
                Console.WriteLine();
            }
        }
        static void LinePrint(int whight, int GorisontNum, int GorisontPass, string LineStart, string LineInside, string LineEnd)
        {
            GorisontPassing(GorisontPass);
            Console.Write(LineStart);
            for (int i = 1; i <= GorisontNum; i++)
            {
                for (int j = 0; j < whight; j++)
                {
                    Console.Write("─");
                }
                if (i != GorisontNum) Console.Write(LineInside);
            }
            Console.WriteLine(LineEnd);
        }
        static void WhitespacePrint(int whight, int GorisontNum, int GorisontPass)
        {
            for (int i = 0; i < GorisontNum; i++)
            {
                Console.Write("│");
                for (int j = 0; j < whight; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("│");
        }
        static void ReColour (int gorID, int vertID, int gorisontPass, int vertPass, int hight, int whight)
        {
            Console.SetCursorPosition((gorisontPass + (gorID * (whight - 3)) + 1), (vertPass + (vertID * (hight - 2)) + 1));
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < hight; i++)
            {
                Console.SetCursorPosition((gorisontPass + (gorID * (whight - 5)) + 1), (vertPass + (vertID * (hight - 2)) + 1));
                for (int j = 0; j < whight; j++)
                {
                    Console.Write(" ");
                }
                if (i == (hight-1)) Console.SetCursorPosition((gorisontPass + (gorID * whight) + 1), (vertPass + (vertID * hight) + 1));
            }
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
