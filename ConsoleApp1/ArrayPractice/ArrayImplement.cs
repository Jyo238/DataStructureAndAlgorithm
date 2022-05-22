using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayPractice
{
    class MyArray
    {
        private int length;
        private object[] data;
        public MyArray()
        {
            length = 0;
            data = new object[0];
        }

        public override string ToString()
        {
            return string.Join(",", data);
        }

        public object Get(int index)
        {
            return data[index];
        }

        public int Push(object item)
        {

            if (data.Length == length)
            {
                //新增一個臨時陣列
                object[] temp = new object[length];
                //把原先資料倒到臨時陣列
                Array.Copy(data, temp, length);
                //data再多一個位址出來
                data = new object[length + 1];
                //把資料從臨時陣列倒回來
                Array.Copy(temp, data, length);

            }

            //加
            data[length] = item;
            length++;
            return length;
        }

        public object Pop()
        {
            var lastItem = data[length - 1];
            data[length - 1] = null;
            length--;

            //Array.Resize(ref data, data.Length - 1);
            return lastItem;
        }

        public object delete(int index)
        {
            var itemToDelete = data[index];
            ShiftItem(index);
            return itemToDelete;
        }

        private void ShiftItem(int index)
        {
            for (var i = index; i < length - 1; i++)
            {
                //[0,2] => [2]
                data[i] = data[i + 1];
            }

            data[length - 1] = null;
            length--;
        }
    }
    class ArrayImplement
    {
        //static void Main(string[] args)
        //{
        //    var newArray = new MyArray();
        //    newArray.Push("hello");
        //    newArray.Push("world");
        //    newArray.Push("!");
        //    newArray.Push("y");
        //    newArray.delete(2);
        //    newArray.Push(".");
        //    newArray.delete(3);
        //    Console.WriteLine($"Get function:{newArray}");
        //}
    }
}
