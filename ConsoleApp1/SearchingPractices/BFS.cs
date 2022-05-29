using ConsoleApp1.TreePractice.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SearchingPractices
{

    class BFSPractice
    {
        private TreeNode root;

        public BFSPractice(BinarySearchTree tree)
        {
            root = tree?.root;
        }

        public List<int> BreadthFirstSearch()
        {
            TreeNode current;
            var list = new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                list.Add(current.val);
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
            return list;

        }

        public List<int> BreadthFirstSearchR(Queue<TreeNode> queues, List<int> list)
        {
            if (queues.Count == 0) return list;
            var current = queues.Dequeue();
            list.Add(current.val);
            if (current.left != null)
            {
                queues.Enqueue(current.left);
            }
            if (current.right != null)
            {
                queues.Enqueue(current.right);
            }

            return BreadthFirstSearchR(queues, list);
        }
    }

    class BFS
    {



        //static void Main()
        //{
        //    BinarySearchTree tree = new BinarySearchTree();
        //    tree.Insert(9);
        //    tree.Insert(4);
        //    tree.Insert(6);
        //    tree.Insert(20);
        //    tree.Insert(170);
        //    tree.Insert(15);
        //    tree.Insert(1);
        //    var p = new BFSPractice(tree);

        //    var aaa = p.BreadthFirstSearch();
        //    var q = new Queue<BSTNode>();
        //    var list = new List<int>();
        //    q.Enqueue(tree.root);
        //    var bbb = p.BreadthFirstSearchR(q,list);
        //    Console.WriteLine(123);
        //}


    }
}
