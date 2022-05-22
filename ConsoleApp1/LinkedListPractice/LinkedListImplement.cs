using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LinkedListPractice
{
    public class LinkedNode
    {
        public int Value;
        public LinkedNode Next;

        public LinkedNode(int value)
        {
            Value = value;
            Next = null;
        }


    }

    class MyLinkedList
    {
        public LinkedNode Head;
        public LinkedNode Tail;
        public int Length;
        public MyLinkedList(int value)
        {
            Head = new LinkedNode(value);
            Tail = Head;
            Length = 1;
        }

        public void Append(int value)
        {
            var newNode = new LinkedNode(value);
            Tail.Next = newNode;
            Tail = newNode;
            Length++;
        }

        public void Prepend(int value)
        {
            var newNode = new LinkedNode(value);
            newNode.Next = Head;
            Length++;
        }
    }

    class LinkedListImplement
    {
        //static void Main(string[] args)
        //{
        //    var myLinkedList = new MyLinkedList(10);
        //    myLinkedList.Append(5);
        //    myLinkedList.Append(16);
        //    Console.WriteLine(myLinkedList);
        //}
    }
}
