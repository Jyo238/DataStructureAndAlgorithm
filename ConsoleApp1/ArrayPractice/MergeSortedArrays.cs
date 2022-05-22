using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ArrayPractice
{
    //字串版
    static class MergeSortedArraysExtensions
    {
        public static string ToStrings(this int[] array) => array != null && array.Any() ? $"[{string.Join(",", array)}]" : string.Empty;
    }


    class MergeSortedArrays
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var a = nums[i];
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;

                    var b = nums[j];

                    //if (a + b > target)
                    //{
                    //    break;
                    //}

                    if (a + b == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return new int[2] { 0, 1 };
        }



        //static void Main(string[] args)
        //{
        //    //should be [0,3,4,4,30,31];
        //    //var result = MergeSortedArray(new int[] { 0, 3, 4, 31,123,666,775,3344,77788 }, new int[] { 4, 6, 30,66,88 });
        //    var result = TwoSum(new int[]{-1, -2, -3, -4, -5},- 8);
        //    Console.WriteLine(result);
        //}

        private static bool IsArray(int[] array) => array != null && array.Any();

        public static int[] MergeSortedArray(int[] array1, int[] array2)
        {

            //這邊先確定array1 跟 array2有沒有鬼
            if (!IsArray(array1) && !IsArray(array2))
            {
                return null;
            }

            if (!IsArray(array1))
            {
                return array2;
            }

            if (!IsArray(array2))
            {
                return array1;
            }

            #region 方法1
            var mergeArray = new int[array1.Length + array2.Length];

            var a1Length = 0;
            var a2Length = 0;
            var i = 0;
            while(i < mergeArray.Length)
            {
                //這邊 如果某個陣列無法再比較 直接回傳另一個陣列的值 然後繼續比
                if(a1Length > array1.Length-1)
                {
                    mergeArray[i] = array2[a2Length];
                    i++;
                    a2Length++;
                    continue;
                }

                if (a2Length > array2.Length - 1)
                {
                    mergeArray[i] = array1[a1Length];
                    i++;
                    a1Length++;
                    continue;
                }

                var array1Item = array1[a1Length];
                var array2Item = array2[a2Length];
                if (array1Item < array2Item)
                {
                    mergeArray[i] = array1Item;
                    a1Length++;
                }
                else
                {
                    mergeArray[i] = array2Item;
                    a2Length++;
                }
                i++;
            }

            return mergeArray;
            #endregion


            //方法2
            //return array1.ToList().Concat(array2.ToList()).OrderBy(x=>x).ToArray();
        }
    }
}
