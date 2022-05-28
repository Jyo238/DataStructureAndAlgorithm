using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SortingPractices
{
    class MergeSort : SortBase<int>
    {
        public MergeSort(int[] array) : base(array)
        {
        }



        /// <summary>
        /// 組合排序。
        /// </summary>
        /// <param name="list">串列。</param>
        /// <param name="left">左邊極限。</param>
        /// <param name="right">右邊極限。</param>
        public static void ToMergeSort(int[] list, int left, int right)
        {
            int mid;
            if (left < right)
            {
                mid = (left + right) / 2;
                ToMergeSort(list, left, mid);//排序左半邊
                ToMergeSort(list, mid + 1, right);//排序右半邊
                Merge(list, left, mid, right);//組合
            }
        }

        public static void Merge(int[] list, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];//設定暫存陣列長度
            int left1 = left, left2 = mid + 1, index = 0;//設定左邊極限
            while ((left1 <= mid) && (left2 <= right))
            {
                if (list[left1] < list[left2])
                {
                    temp[index] = list[left1];
                    left1++;
                    index++;
                }
                else
                {
                    temp[index] = list[left2];
                    left2++;
                    index++;
                }
            }
            while (left1 <= mid)
            {
                temp[index] = list[left1];
                left1++;
                index++;
            }
            while (left2 <= right)
            {
                temp[index] = list[left2];
                left2++;
                index++;
            }
            for (int i = 0; i < right - left + 1; i++)
                list[left + i] = temp[i];
        }


        public override void ToSort()
        {
            ToMergeSort(array, 0, array.Length - 1);
        }
    }
}
