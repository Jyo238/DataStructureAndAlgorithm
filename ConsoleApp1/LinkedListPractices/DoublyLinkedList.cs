using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LinkedListPractices
{
    class DoublyLinkeNode
    {
        public int Value;
        public DoublyLinkeNode? Previous;
        public DoublyLinkeNode? Next;

        public DoublyLinkeNode(int value)
        {
            Value = value;
            Previous = null;
            Next = null;
        }
    }

    public class MyDoublyLinkedList
    {
        private DoublyLinkeNode Head;
        private DoublyLinkeNode Tail;
        private int Length;

        public MyDoublyLinkedList(int value)
        {
            Head = new DoublyLinkeNode(value);
            Tail = Head;
            Length = 1;
        }


        public void Prepend(int value)
        {
            /// X-> * -> *
            /// 
            /// newNode =>新節點
            /// newNode.Next => 原先的Head
            /// Tail.Next = Head.Next;
            /// Tail本身 = newNode

            var newNode = new DoublyLinkeNode(value);
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
            Length++;
        }

        public void Append(int value)
        {

            /// * -> *-> X
            /// 
            /// newNode =>新節點
            /// newNode.Prev => 原先的Tail
            /// Tail.Next = Head.Next;
            /// Tail本身 = newNode
            var newNode = new DoublyLinkeNode(value);
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
            Length++;
        }

        public List<int> Insert(int index, int value)
        {
            //// *->*->*
            ///變成
            ///  *     *  *
            ///   \   /
            ///     * 
            ///所以 取得index前一個值 設為leader, leader.Next = holder  然後 把leader.Next 設為newNode,newNode.Next設為holder. 搞定.


            if (index == 0)
            {
                Prepend(value);
                return PrintList();
            }

            if (index >= Length)
            {
                Append(value);
                return PrintList();
            }

            var newNode = new DoublyLinkeNode(value);
            var leader = TraverToIndex(index - 1);

            if (leader != null)
            {
                var follower = leader.Next;

                leader.Next = newNode;

                newNode.Previous = leader;
                newNode.Next = follower;

                follower.Previous = newNode;
                Length++;
            }

            return PrintList();

        }

        public List<int> Remove(int index)
        {
            //// 0  1  2
            //// *->*->*
            ///變成
            ///  0    2
            ///  * -> *
            ///所以 取得 0   然後 1.next = follower 然後 把0.Next = follower
            ///  0 1  2
            ///  變成  0  1
            ///  所以 直接把1.Next = null
            if (index >= Length) index = Length - 1;


            var leader = TraverToIndex(index - 1);
            if (leader != null)
            {
                var removed = leader.Next;
                var follower = removed?.Next;
                leader.Next = follower;
                follower.Previous = leader;
                Length--;
            }

            return PrintList();
        }


        public List<int> PrintList()
        {
            var list = new List<int>();
            var current = Head;
            while (current != null)
            {
                list.Add(current.Value);
                current = current.Next;
            }
            return list;
        }

        DoublyLinkeNode? TraverToIndex(int index)
        {
            var current = Head;
            var i = 0;
            while (i < index)
            {
                if (current != null)
                {
                    current = current.Next;
                    i++;
                }

            }
            return current;
        }



    }

    internal class DoublyLinkedList
    {
        //static void Main()
        //{
        //    var l = new MyDoublyLinkedList(10);
        //    l.Append(29);
        //    l.Append(87);
        //    l.Prepend(22);
        //    l.Insert(1,123);
        //    l.Remove(3);
        //    Console.WriteLine(l);
        //}
    }
}
