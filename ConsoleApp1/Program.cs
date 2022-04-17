using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            int[,] arr = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = num < 9 ? ++num : num = 0;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j].ToString() + '\t');
                }
                Console.Write('\n');
            }
        }
    }
}
