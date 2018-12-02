using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
    class MyString
    {
        private char[] array;
        private string s;
        public MyString(char[] value)
        {
            array = value;
        }


        public MyString(char c, int count)
        {
            array = new char[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = c;
            }
        }

        public char this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public int StrLength => array.Length;

        public static bool IsEqual(MyString a, MyString b)
        {
            if (a.StrLength != b.StrLength)
            {
                return false;
            }

            for (int i = 0; i < a.StrLength; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static MyString Concat(MyString str0, MyString str1)
        {
            char[] str2 = new char[str0.StrLength + str1.StrLength];

            for (int i = 0; i < str0.StrLength; i++)
            {
                str2[i] = str0[i];
            }

            for (int i = 0; i < str1.StrLength; i++)
            {
                str2[i + str0.StrLength] = str1[i];
            }

            return new MyString(str2);
        }

        public static MyString Concat(MyString str0, MyString str1, MyString str2)
        {
            char[] str3 = new char[str0.StrLength + str1.StrLength + str2.StrLength];

            for (int i = 0; i < str0.StrLength; i++)
            {
                str3[i] = str0[i];
            }

            for (int i = 0; i < str1.StrLength; i++)
            {
                str3[i + str0.StrLength] = str1[i];
            }

            for (int i = 0; i < str2.StrLength; i++)
            {
                str3[i + str0.StrLength + str1.StrLength] = str2[i];
            }

            return new MyString(str3);
        }


        public static MyString operator + (MyString str0, MyString str1)
        {
            return Concat(str0, str1);
        }

        public char[] ToChArray()
        {
            return array;
        }
        
        public override string ToString()
        {
            return new string(array); 
        }
    }
}
