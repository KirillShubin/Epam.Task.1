using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ArrayProcessing
{
    class Program
    {
        static int[] GetSortedArr(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] > nums[k])
                    {
                        temp = nums[i];
                        nums[i] = nums[k];
                        nums[k] = temp;
                    }
                }
            }
            return nums;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[30];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 300);
            }

            int[] sortedArr = GetSortedArr(arr);
            Console.WriteLine("Отсортированный массив случайных чисел:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(sortedArr[i]);
            }
        }

    }
}
