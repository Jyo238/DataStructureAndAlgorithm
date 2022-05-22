using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StackAndQueuePractices.StackAndQueueImplement
{

    class QueueStackNode
    {
        public string Value;
        public QueueStackNode? Next;

        public QueueStackNode(string value)
        {
            Value = value;
            Next = null;
        }
    }

    class MyQueue
    {
        public QueueStackNode? First;
        public QueueStackNode? Last;
        public int Length = 0;

        public MyQueue()
        {
            First = null;
            Last = null;
            Length = 0;
        }

        public QueueStackNode? Peek()
        {
            return First;
        }

        public void Enqueue(string value)
        {
            var newNode = new QueueStackNode(value);
            if (Length == 0)
            {
                First = newNode;
                Last = newNode;
            }
        }

        public void Dequeue()
        {
            
        }
    }


    internal class QueueByLinkedList
    {
        static void Main()
        {
            //Stack -> google,udemy,youtube
            //so 
            //youtube
            //udemy
            //google

            /// Stack null
            ///append -> [google]
            ///append -> [google,udemy]
            ///append -> [google,udemy,youtube]
            var myStack = new MyStackByArrayList();
            myStack.Push("google");
            myStack.Push("udemy");
            myStack.Push("youtube");
            myStack.Pop();
            var a = myStack.Peek();
            Console.WriteLine(myStack);
        }
    }
}
