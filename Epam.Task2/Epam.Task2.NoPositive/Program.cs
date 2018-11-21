using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[1, 2, 2];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i,i,i] = random.Next(-20, 20);
            }
        }
    }
}
