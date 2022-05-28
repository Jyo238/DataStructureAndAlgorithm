using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SortingPractices
{
    class SelectionSort : SortBase<int>
    {
        public SelectionSort(int[] array) : base(array)
        {

        }
        public override void ToSort()
        {
            // 1, 2, 7, 43, 78, 22, 76, 123, 83, 5
            for (int i = 0; i < array.Length; i++)
            {
                //this is index
                int min = i;
                //this is value
                var temp = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        //target index
                        min = j;
                    }
                }

                array[i] = min;
                array[min] = temp;
            }
        }
    }
}
