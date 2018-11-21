using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N (количество строк): ");
            int n;

            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    for (int i = 0; i <= n; i++)
                    {
                        Console.WriteLine(new String('*', i));
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести целое положительное число! Повторите ввод и нажмите Enter");
                }
            }
            
        }
    }
}
