using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StackAndQueuePractices.StackAndQueueImplement
{

    class MyQueueByStack
    {
        public Stack<int> normalStack;
        public Stack<int> reverseStack;
        public MyQueueByStack()
        {
            normalStack = new Stack<int>();
            reverseStack = new Stack<int>();
        }

        //思路 enqueue時 正常存入normalStack內 為 O(1)
        //dequeue、peek時 把normalStack翻轉至reverseStack並存入 第一次為O(n)
        //然後就可以直接使用reverseStack的peek跟pop 這邊就為O(1)

        public void ShiftStack()
        {
            if (normalStack.Count == 0 && reverseStack.Count == 0)
            {
                Console.WriteLine("Empty Queue.");
                Environment.Exit(0);
            }

            if (reverseStack.Count == 0)
            {
                while (normalStack.Count != 0)
                {
                    var x = normalStack.Pop();
                    reverseStack.Push(x);
                }
            }
        }

        public void Enqueue(int value)
        {
            normalStack.Push(value);
        }

        public int Dequeue()
        {
            ShiftStack();
            return reverseStack.Pop();
        }

        public int Peek()
        {
            ShiftStack();
            return reverseStack.Peek();
        }

    }




    class QueueByStack
    {
        //public static void Main(String[] args)
        //{
        //    var q = new MyQueueByStack();

        //    q.Enqueue(1);
        //    q.Enqueue(2);
        //    q.Enqueue(3);
        //    q.Enqueue(4);
        //    var peek = q.Peek();
        //    /* Dequeue items */
        //    Console.Write(q.Dequeue());
        //    Console.Write(q.Dequeue());
        //    Console.WriteLine(q.Dequeue());

        //    q.Enqueue(5);
        //    q.Enqueue(6);
        //    q.Enqueue(7);
        //    var peek2 = q.Peek();
        //    Console.Write(q.Dequeue());
        //}
        ///// queue null
        /////append -> [google]
        /////append -> [google,udemy]
        /////append -> [google,udemy,youtube]
    }
}
