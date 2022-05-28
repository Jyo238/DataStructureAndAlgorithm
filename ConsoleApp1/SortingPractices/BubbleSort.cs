using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SortingPractices
{
    class BubbleSort : SortBase<int>
    {
        public BubbleSort(int[] array) : base(array)
        { 
        
        }
        public override void ToSort()
        {
            // 1, 2, 7, 43, 78, 22, 76, 123, 83, 5
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        var temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }

    }
}
