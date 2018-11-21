using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.XMassTree
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N (количество треугольников): ");
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

            for (int i = 0; i <= n; i++)
            {
                int counter = 1;

                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k < n - j; k++)
                    {
                        Console.Write(" ");
                    }

                    for (int h = 0; h < counter; h++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                    counter += 2;
                }
            }
        }
    }
}
