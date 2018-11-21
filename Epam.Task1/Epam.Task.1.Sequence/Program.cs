using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        public static string GetSequence(int N)
        {
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = i + 1;
            }
            return String.Join(", ", arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSequence(7));
        }
    }
}
