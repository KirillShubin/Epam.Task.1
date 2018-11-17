using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        public static void PrintSquare(int N)
        {
            int center = (N + 1) / 2;
            for (int i = 1; i <= N; i++)
            {
                for (int k = 1; k <= N; k++)
                {
                    if ((i == center) && (k == center))
                    {
                        Console.Write(' ');
                        k++;
                    }
                    Console.Write('*');
                }
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            PrintSquare(7);
        }
    }
}
