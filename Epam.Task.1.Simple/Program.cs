using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class Program
    {
        public static bool IsSimple(int N)
        {
            for (int i = 2; i <= 9; i++)
            {
                if ((N % i) == 0 && (N != i))
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsSimple(7));
        }
    }
}
