using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._2DArray
{
    class Program
    {
        static void InitArray(int[,] _arr)
        {
            Random random = new Random();
            for (int i = 0; i < _arr.GetLongLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLongLength(1); j++)
                {
                    _arr[i, j] = random.Next(0, 30);
                }

            }
        }
        static int GetSummOfEvenNumberedElements(int[,] _arr)
        {
            int summ = 0;
            for (int i = 0; i < _arr.GetLongLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLongLength(1); j++)
                {
                    if ((i + j) > 0 && (i + j) % 2 == 0)
                    {
                        summ += _arr[i,j];
                    }
                }
            }
            return summ;
            
        }
        static void Main(string[] args)
        {
            int a = 6;
            int b = 4;
            int[,] arr = new int[a, b];

            InitArray(arr);
            Console.WriteLine($"Сумма элементов массива, стоящих на четных позициях: {GetSummOfEvenNumberedElements(arr)}");
        }
    }
}
