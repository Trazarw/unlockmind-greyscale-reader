using System;

namespace Unlockmind.GreyscaleReader
{
    public class ConsleDisplayScaleArray
    {
        public ConsleDisplayScaleArray(double[,] array, int height, int width)
        {
            RBDisplay(array, height, width);
            WriteArray(array, height, width);
        }

        private void RBDisplay(double[,] array, int height, int width)
        {
            Console.WriteLine("Red/Blue Visualization");
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double current = array[i, j];
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    if (current > 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        if (current > 0.51) Console.BackgroundColor = ConsoleColor.Blue;
                        if (current.Equals(1.0)) Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($"{current:0.0}|");
                }
                Console.ResetColor();
                Console.WriteLine("");
            }

        }

        private void WriteArray(double[,] array, int height, int with)
        {
            Console.WriteLine();
            Console.WriteLine("Raw Array");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("[");
            for (int i = 0; i < with; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double current = array[i, j];
                    if (i == 0 && j == 0)
                    {
                        Console.Write(current);
                        continue;
                    }
                    Console.Write($", {current}");
                }
                Console.Write("]");
            }
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}