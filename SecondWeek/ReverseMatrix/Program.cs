using System;

namespace ReverseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a = {
            {10, 20, 30, 6, 4},
            {40, 40, 60, 8, 7},
            {60, 80, 90, 4, 3},
            {6, 8, 9, 4, 3}};

            int[,] reversedArray = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                }

            }

            foreach (var item in reversedArray)
            {
                Console.WriteLine(item);
            }
        }



    }
}
