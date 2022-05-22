using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ArrayPractice
{
    class ArrayReverseString
    {
        //static void Main(string[] args)
        //{
        //    var str = "What does the fox say?";
        //    var str2 = Reverse(str);
        //    Console.WriteLine(str2);
        //}

        public static string Reverse(string str)
        {
            //方法1 用string builder的方式
            var sb = new StringBuilder();
            for(var i= str.Length-1; i>=0;i--)
            {
                sb.Append(str[i]);
            }
            //return sb.ToString();

            //方法2 用char array的方式
            var backwords = new char[str.Length];
            for (var i = str.Length - 1; i >= 0; i--)
            {
                backwords[(str.Length - 1)-i] = str[i];
            }

            //return string.Join(string.Empty, backwords);
            //方法3 linq
            return string.Join(string.Empty, str.Reverse());

        }
    }
}
