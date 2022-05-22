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
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }

            Length++;
        }

        public void Dequeue()
        {
            if(First == null)
            {
                return;
            }

            if(First == Last)
            {
                Last = null;
            }
            var holder = First;
            First = First.Next;
            Length--;
            //如果你想要知道你Dequeue了什麼，return holder;
        }
    }


    internal class QueueByLinkedList
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
        //    ///append -> [google,udemy]
        //    ///append -> [google,udemy,youtube]
        //    var myStack = new MyQueue();
        //    myStack.Enqueue("google");
        //    myStack.Enqueue("udemy");
        //    myStack.Enqueue("youtube");
        //    myStack.Dequeue();
        //    var a = myStack.Peek();
        //    Console.WriteLine(myStack);
        //}
    }
}
