using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.CharDoubler
{
    class Program
    {
        static string GetChangedString (string s1, string s2)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s1.Length; i++)
            {
                sb.Append(s1[i]);

                for (int j = 0; j < s2.Length; j++)
                {
                    if (char.ToLower(s1[i]).CompareTo(char.ToLower(s2[j])) == 0)
                    {
                        sb.Append(s1[i]);
                        break;
                    }
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            
            Console.WriteLine($"Измененная строка: {GetChangedString(str1, str2)}");
        }
    }
}
