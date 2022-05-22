using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StackAndQueuePractices.StackAndQueueImplement
{
    class StackNode
    {
        public string Value;
        public StackNode? Next;

        public StackNode(string value)
        {
            Value = value;
            Next = null;
        }
    }

    class MyStack
    {
        private int Length;
        private StackNode? Top;
        private StackNode? Bottom;
        public MyStack()
        {
            Length = 0;
            Top = null;
            Bottom = null;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }

        //Stack -> google,udemy.com,youtube
        //so 
        //youtube
        //udemy
        //google

        public StackNode? Peek()
        {
            return Top;
        }

        public void Pop()
        {
            if (Top == null) return;
            if (Top == Bottom) Bottom = null;
            //var holder = Top;
            Top = Top.Next;
            Length--;
            //這邊 看你只是想刪掉 或者是說你想知道你刪了什麼
            //return holder;

        }

        public void Push(string value)
        {

            /// Stack null
            ///append -> [google]
            ///append -> [udemy,google]
            ///append -> [youtube,udemy,google]
            //  然後top變成new,原本的top 變成 bottom
            //這個 prePend實作
            var newNode = new StackNode(value);
            if (IsEmpty())
            {
                Top = newNode;
                Bottom = newNode;

            }
            else
            {

                newNode.Next = Top;
                Top = newNode;
                //Bottom = Top;
            }
            Length++;

        }
    }
    internal class StackByLinkedList
    {
        //static void Main()
        //{
        //    //Stack -> google,udemy,youtube
        //    //so 
        //    //youtube
        //    //udemy
        //    //google

        //    //Arrays V 
        //    //Linked Lists


        //    //Queue -> Tim,Chelsea,Johnny
        //    //so
        //    //Tim ->Chelsea ->Johnny

        //    //Arrays
        //    //Linked Lists V

        //    var stack = new MyStack();
        //    stack.Push("google");
        //    stack.Push("udemy");
        //    stack.Push("youtube");

        //    var peek = stack.Peek();
        //    stack.Pop();
        //    Console.WriteLine(stack);
        //}
    }
}
