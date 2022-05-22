using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.HashTablePractice
{
    class FirstRecurringNumber
    {
        //static void Main(string[] args)
        //{
        //    var aaa = new int[] { 2, 1, 1, 2, 3, 5, 1, 2, 4 };
        //    //var aaa = new int[] { 2, 3,4,5 };
        //    Console.WriteLine(FirstNumber1(aaa));
        //    Console.WriteLine(FirstNumber2(aaa));
        //}

        public static int? FirstNumber2(int[] array)
        {
            //var h = new Hashtable();
            //foreach(var item in array)
            //{

            //    if(h.ContainsKey(item))
            //    {
            //        return (int)h[item];
            //    }
            //    else
            //    {
            //        h[item] = item;
            //    }
            //}


            var dictionarys = new Dictionary<int,int>();
            foreach (var item in array)
            {

                if (dictionarys.TryGetValue(item,out int value))
                {
                    return value;
                }
                else
                {
                    dictionarys.Add(item, item);
                }
            }
            return null;
        }

        public static int? FirstNumber1(int[] array)
        {
            for(var i =0;i<array.Length;i++)
            {
                for(var j=i+1;j<array.Length;j++)
                {
                    if (array[i] == array[j]) return array[i];
                }
            }
            return null;
        }
    }
}
