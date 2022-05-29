using ConsoleApp1.TreePractice.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SearchingPractices
{
    class DFSPractice
    {
        private TreeNode root;

        public DFSPractice(BinarySearchTree tree)
        {
            root = tree?.root;
        }

        public List<int> DeepFirstSearchInOrder()
        {
            return TraversalInOrder(root,new List<int>());
        }
        //     9
        //  4      20
        //1   6  15  170

        //inorder-[1,4,6,9,15,20,170]

        private List<int> TraversalInOrder(TreeNode node, List<int> list)
        {
            if(node.left != null)
            {
                TraversalInOrder(node.left, list);
            }
            list.Add(node.val);

            if (node.right != null)
            {
                TraversalInOrder(node.right, list);
            }

            return list;
        }

        public List<int> DeepFirstSearchPostOrder()
        {
            return TraversalPostOrder(root, new List<int>());
        }
        //postorder-[1,6,4,15,170,20,9]
        private List<int> TraversalPostOrder(TreeNode node, List<int> list)
        {
             if(node.left != null)
            {
                TraversalPostOrder(node.left, list);
            }
            

            if (node.right != null)
            {
                TraversalPostOrder(node.right, list);
            }
            list.Add(node.val);
            return list;
        }

        public List<int> DeepFirstSearchPreOrder()
        {
            return TraversalPreOrder(root, new List<int>());
        }
        //preorder-[9,4,1,6,20,15,170]
        private List<int> TraversalPreOrder(TreeNode node, List<int> list)
        {
            list.Add(node.val);
            if (node.left != null)
            {
                TraversalPreOrder(node.left, list);
            }

            if (node.right != null)
            {
                TraversalPreOrder(node.right, list);
            }

            return list;
        }
    }

    class DFS
    {
        // static void Main()
        //{
        //    BinarySearchTree tree = new BinarySearchTree();
        //    tree.Insert(9);
        //    tree.Insert(4);
        //    tree.Insert(6);
        //    tree.Insert(20);
        //    tree.Insert(170);
        //    tree.Insert(15);
        //    tree.Insert(1);
        //    var p = new DFSPractice(tree);
        //    //     9
        //    //  4      20
        //    //1   6  15  170

        //    //inorder-[1,4,6,9,15,20,170]
        //    var inOrder = p.DeepFirstSearchInOrder();
        //    //postorder-[1,6,4,15,170,20,9]
        //    var postOrder = p.DeepFirstSearchPostOrder();
        //    //preorder-[9,4,1,6,20,15,170]
        //    var preOrder = p.DeepFirstSearchPreOrder();
        //    Console.WriteLine("OK");
        //}
    }
}
