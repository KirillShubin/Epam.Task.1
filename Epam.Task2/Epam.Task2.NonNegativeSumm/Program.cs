using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NonNegativeSumm
{
    class Program
    {
        static void InitArray(int[] _arr)
        {
            Random random = new Random();

            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = random.Next(-300, 300);
            }
        }

        static int GetSummNonNegative(int[] _arr)
        {
            int summ = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if(_arr[i] >= 0)
                {
                    summ += _arr[i];
                }
            }
            return summ;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[50];
            InitArray(arr);
            Console.WriteLine($"Сумма всех неотрицательных элементов массива равна: {GetSummNonNegative(arr)}");
        }
    }
}
