using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SortingPractices
{
    class QuickSort : SortBase<int>
    {
        public QuickSort(int[] array) : base(array)
        {
        }

        public static void ToQuickSort(int[] list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);
                ToQuickSort(list, left, pivot - 1);
                ToQuickSort(list, pivot + 1, right);
            }
        }

        private static int Partition(int[] list, int left, int right)
        {
            int i = left - 1;
            int j = right;
            int pivot = list[right];        // 取分區的基準元素

            while (true)
            {
                while (list[++i] < pivot)   // 右向指標
                    if (i == right)
                        break;
                while (list[--j] > pivot)    // 左向指標
                    if (j == left)
                        break;
                if (i >= j)        		// 將左右指標交會?
                    break;
                Swap(list, i, j);         // 將左右指標所指元素對調
            }
            Swap(list, i, right);         // 左指標所指元素和基準元素對調
            return i;
        }

        public static void Swap(int[] list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }


        public override void ToSort()
        {
            ToQuickSort(array, 0, array.Length - 1);
        }

        public int[] ToArray()
        {
            return array;
        }
    }
}
