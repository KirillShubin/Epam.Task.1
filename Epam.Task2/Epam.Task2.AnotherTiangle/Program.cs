using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AnotherTiangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N (количество строк): ");
            int n;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести целое положительное число! Повторите ввод и нажмите Enter");
                }
            }
            int i;
            int j;
            int m;

            for (i = n; i != 0; i--)
            {
                for (j = i; j != 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (m = (n - i) * 2; m != 0; m--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
