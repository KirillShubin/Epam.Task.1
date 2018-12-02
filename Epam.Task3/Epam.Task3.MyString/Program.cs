using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString s1 = new MyString(new char[] {'h', 'e'});
            MyString s2 = new MyString('l', 2);
            MyString s3 = new MyString(new char[] { 'o' });
            MyString s4 = MyString.Concat(s1, s2, s3);
            s4 = s1 + s2 + s3;
            
            Console.WriteLine("s1 = {0};\ns2 = {1};\ns3 = {2};\ns4 = {3};", s1, s2, s3, s4);

            int length = s4.StrLength;
            Console.WriteLine("Длина строки: {0}", length);

            if (MyString.IsEqual(s4, s1))
            {
                Console.WriteLine("Строка {0} равна строке {1}", s4, s1);
            }
            else
            {
                Console.WriteLine("Строки {0} и {1} неравны", s4, s1);
            }

            char ch = s4.ToChArray()[0];
            Console.WriteLine("Нулевой символ: {0}", ch);
        }
    }
}
