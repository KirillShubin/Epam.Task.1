using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AverageStringLength
{
    class Program
    {
        static int CountChars(string _str)
        {
            char[] _arr = _str.ToCharArray();
            int count = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (char.IsLetter(_arr[i]))
                    count++;
            }
            return count;
        }

        static int CountWords(string _str)
        {
            char[] _arr = _str.ToCharArray();
            int count = 0;
            for (int i = 0; i < _arr.Length - 1; i++)
            {
                if (char.IsLetter(_arr[i]) && ((char.IsSeparator(_arr[i + 1]) || char.IsPunctuation(_arr[i + 1]))))
                {
                    count++;
                }
            }
            count++;
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение из нескольких слов");
            string str = Console.ReadLine();

            double averageLength = (double)CountChars(str) / CountWords(str);
            Console.WriteLine($"Средняя длина слова в предложении: {averageLength}");
        }
    }
}
