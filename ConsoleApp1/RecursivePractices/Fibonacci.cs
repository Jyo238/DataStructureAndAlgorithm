using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RecursivePractices
{
    internal class Fibonacci
    {
        static long FibonacciIterative(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;
            var lastNumber = 0;
            var result = 1;
            //0,1,1,2,3,5,8
            for(var i =1;i<number;i++)
            {
                //0
                //1
                //1
                var temp = lastNumber;
                //1
                //1 
                //2
                lastNumber = result;
                //0+1
                //1+1
                //2+1
                result += temp;
            }

            return result;
        }
        //O(2^n)
        static long FibonacciRecursive(int number)
        {
            if (number < 2) return number;

            return FibonacciRecursive(number-1) + FibonacciRecursive(number - 2);
        }

        //static void Main()
        //{
        //    var answer= FibonacciIterative(6);
        //    var a2 = FibonacciRecursive(6);
        //    Console.WriteLine("OK");
        //}
    }
}
