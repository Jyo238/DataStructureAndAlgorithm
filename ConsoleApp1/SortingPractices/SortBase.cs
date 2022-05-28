using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.SortingPractices
{
    public class SortBase<T>
    {
        public readonly T[] array;
        public SortBase(T[] array)
        {
            this.array = array;
        }
        public virtual void ToSort()
        { 
        }

        public override string ToString()
        {
            return string.Join(",", array.Select(x => x.ToString()));
        }
    }
}
