using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DynamicProgrammingPractices
{
    class FibonacciDP
    {
        private static readonly Dictionary<int, long> dic = new Dictionary<int, long>();
        private static long FibDPRecursive(int n)
        {
            if(dic.TryGetValue(n,out long val))
            {
                return val;
            }
            else
            {
                if(n< 2)
                {
                    return n;
                }
                else
                {
                    dic.Add(n,FibDPRecursive(n - 1) + FibDPRecursive(n - 2));
                    return dic[n];
                }
            }
        }

        private static long FibDPRecursive(int n, int prev, int result)
        {
            if (n < 2) return n;
            //var temp = prev;
            result += prev;
            prev = result;
            n--;
            return FibDPRecursive(n, prev, result);
        }

        public static long Fib(int n) //O(2^n)
        {
            if (n < 2) return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main()
        {
            var result = Fib(10);
            var r2 = FibDPRecursive(10);
            Console.WriteLine(result);
        }
    }
}
