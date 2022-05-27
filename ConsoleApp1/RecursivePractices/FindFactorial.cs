using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RecursivePractices
{
    class FindFactorial
    {
        public static long FindFactorialRecusive(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            return number * FindFactorialRecusive(number-1);
        }

        public static int FindFactorialIterative(int number)
        {
            if (number <= 1) return number;
            var target = 1;
            for(var i=0;i<number;i++)
            {
                target *= i+1;
            }
            return target;
        }

        //static void Main()
        //{
        //   var r1 = FindFactorialIterative(5);
        //    var r2 = FindFactorialRecusive(5);
        //    Console.WriteLine("OK");
        //}
    }
}
