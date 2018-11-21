using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Rectangle
{
    class Program
    {
        static int GetIntFromConsole(string helloMessage)
        {
            int result = 0;
            
            Console.WriteLine(helloMessage);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести целое положительное число! Повторите ввод и нажмите Enter");
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            int s;

            a = GetIntFromConsole("Введите длину:");
            b = GetIntFromConsole("Введите ширину:");
            s = a * b;

            Console.WriteLine("Площадь прямоугольника равна: {0}", s);
        }
    }
}
