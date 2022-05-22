using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StackAndQueuePractices.StackAndQueueImplement
{

    class MyStackByArray
    {
        private int Length;
        public string[] Arrays;
        public MyStackByArray()
        {
            Length = 1;
            Arrays = new string[Length];
        }
        public string Peek()
        {
            return Arrays[Length - 1];
        }

        public void Push(string value)
        {
            if(Length == 1)
            {
                Arrays[0] = value;
            }
            else
            {
                var temp = new string[Length];
                Array.Copy(Arrays, temp, Length-1);
                temp[Length - 1] = value;
                Arrays = temp;
            }
            Length++;

        }

        public void Pop()
        {
            if(Length == 1)
            {
                return;
            }
            Length--;
            var temp = new string[Length-1];
            Array.Copy(Arrays, temp,Length-1);
            Arrays = temp;
        }


    }

    class MyStackByArrayList
    {
        public ArrayList Arrays;
        public MyStackByArrayList()
        {
            Arrays = new ArrayList();
        }
        public object Peek()
        {
            return Arrays[Arrays.Count - 1] ?? new object();
        }

        public void Push(string value)
        {
            Arrays.Add(value);
        }

        public void Pop()
        {
            Arrays.RemoveAt(Arrays.Count-1);
        }

    }

    internal class StackByArray
    {
        //static void Main()
        //{
        //    //Stack -> google,udemy,youtube
        //    //so 
        //    //youtube
        //    //udemy
        //    //google

        //    /// Stack null
        //    ///append -> [google]
        //    ///append -> [udemy,google]
        //    ///append -> [youtube,udemy,google]
        //    var myStack = new MyStackByArrayList();
        //    myStack.Push("google");
        //    myStack.Push("udemy");
        //    myStack.Push("youtube");
        //    myStack.Pop();
        //    var a = myStack.Peek();
        //    Console.WriteLine(myStack);
        //}
    }
}
