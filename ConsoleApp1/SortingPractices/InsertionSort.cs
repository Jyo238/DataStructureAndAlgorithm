using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SortingPractices
{
    class InsertionSort : SortBase<int>
    {
        public InsertionSort(int[] array) : base(array)
        {
        }

        public override void ToSort()
        {
            int temp, j;
            for (var i = 1; i < array.Length; i++)
            {
                temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j + 1] = temp;
            }

        }
    }
}
