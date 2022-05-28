using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RecursivePractices
{
    class ReverseString
    {
        static string ReverseStr(string str)
        {
            if(string.IsNullOrWhiteSpace(str) )
            {
                return str;
            }
            return ReverseStr(str.Substring(1))+str[0];
        }
        //static void Main()
        //{
        //   var result=  ReverseStr("yoyo mastery");
        //    Console.WriteLine(result);
        //}
    }
}
