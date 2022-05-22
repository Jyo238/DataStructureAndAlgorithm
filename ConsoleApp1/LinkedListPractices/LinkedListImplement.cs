using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LinkedListPractices
{

    public class LinkedNode
    {
        public int Value { get; set; }
        public LinkedNode? Next { get; set; }

        public LinkedNode(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class MyLinkedList
    {
        private LinkedNode Head;
        private LinkedNode Tail;
        private int Length;

        public MyLinkedList(int value)
        {
            Head = new LinkedNode(value);
            Tail = this.Head;
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
            Head = newNode;
            Length++;
        }

        public List<int> PrintList()
        {
            var list = new List<int>();
            var current = Head;
            while(current != null)
            {
                list.Add(current.Value);
                current = current.Next;
            }
            return list;
        }

        public List<int> Insert(int index,int value)
        {

            if (index == 0)
            {
                Prepend(value);
                return PrintList();
            }

            if(index >= Length)
            {
                Append(value);
                return PrintList();
            }

            var newNode = new LinkedNode(value);
            var leader = TraverToIndex(index - 1);
            //// *->*->*
            ///變成
            ///  *     *  *
            ///   \   /
            ///     * 
            ///所以 取得index前一個值 設為leader, leader.Next = holder  然後 把leader.Next 設為newNode,newNode.Next設為holder. 搞定.
            if(leader != null)
            {
                var holder = leader.Next;

                leader.Next = newNode;
                newNode.Next = holder;
                Length++;
            }

            return PrintList();

        }

        public MyLinkedList Reverse()
        {
            var newLinked = PrintList();
            newLinked.Reverse();
            var reverse = new MyLinkedList(Tail.Value);
            for (var i =1;i<newLinked.Count;i++)
            {
                reverse.Append(newLinked[i]);
            }
            return reverse;
        }

        public void Reverse2()
        {
            if(Head.Next == null )
            {
                return;
            }
            //[1 ,10 ,16 ,99]

            //1
            var first = Head;
            Tail = Head;
            //10
            var second = Head.Next;
            while(second != null)
            {
                //16
                var temp = second.Next;
                //[1,10,1,99]
                second.Next = first;
                //[10,10,1,99]
                first = second;
                //[10,16,1,99]
                second = temp;
            }

            Head.Next = null;
            Head = first;
        }


        public List<int> Remove(int index)
        {
            //// 0  1  2
            //// *->*->*
            ///變成
            ///  0    2
            ///  * -> *
            ///所以 取得 0   然後 1.next = holder 然後 把0.Next = holder
            ///  0 1  2
            ///  變成  0  1
            ///  所以 直接把1.Next = null
            if (index >= Length) index = Length-1;


            var leader = TraverToIndex(index - 1);
            if(leader != null)
            {
                var removed = leader.Next;
                var holder = removed?.Next;
                leader.Next = holder;
                Length--;
            }

            return PrintList();
        }



        public LinkedNode? TraverToIndex(int index)
        {
            var current = Head;
            var i = 0;
            while (i < index)
            {
                if(current != null)
                {
                    current = current.Next;
                    i++;
                }

            }
            return current;
        }

    }
    class LinkedListImplement
    {
        // 10->5->16->17->87
        //reverse : 87->17->16->5->10
        //static void Main()
        //{
        //    var l = new MyLinkedList(10);
        //    l.Append(5);
        //    l.Append(16);
        //    l.Append(17);
        //    l.Append(87);
        //    //var lists = l.PrintList();
        //    //var newReverse = l.Reverse();
        //    l.Reverse2();
        //    var lists = l.PrintList();
        //    Console.WriteLine(l);

        //}
    }
}
