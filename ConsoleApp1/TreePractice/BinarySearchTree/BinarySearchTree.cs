using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TreePractice.BinarySearchTree
{
    class TreeNode
    {
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public int val { get; set; }

        public TreeNode(int value)
        {
            left = null;
            right = null;
            this.val = value;
        }
    }

    class BinarySearchTree
    {
        public TreeNode root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            var newNode = new TreeNode(value);
            if (root == null)
            {
                root = newNode;
                return;
            }

            var currentNode = root;
            while (currentNode != null)
            {
                if (currentNode.val > value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        return;
                    }
                    currentNode = currentNode.left;
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        return;
                    }
                    currentNode = currentNode.right;
                }
            }
        }


        public TreeNode Lookup(int value)
        {
            if (root == null)
            {
                return null;
            }

            var currentNode = root;
            while (currentNode != null)
            {

                if (currentNode.val > value)
                {
                    currentNode = currentNode.left;
                }
                else if(currentNode.val < value)
                {
                    currentNode = currentNode.right;
                }
                else if (currentNode.val == value)
                {
                    return currentNode;
                }
            }

            return null;
        }


        public void Remove(int value)
        {
            if (root == null)
            {
                return;
            }

            var nodeToRemove = root;
            TreeNode parentNode = null;
            while (nodeToRemove.val != value)
            { //Searching for the node to remove and it's parent
                parentNode = nodeToRemove;
                if (value < nodeToRemove.val)
                {
                    nodeToRemove = nodeToRemove.left;
                }
                else if (value > nodeToRemove.val)
                {
                    nodeToRemove = nodeToRemove.right;
                }
            }

            TreeNode replacementNode = null;
            if (nodeToRemove.right != null)
            { //We have a Right node
                replacementNode = nodeToRemove.right;
                if (replacementNode.left == null)
                { //We don't have a Left node
                    replacementNode.left = nodeToRemove.left;
                }
                else
                { //We have a have a Left node, lets find the leftmost
                    TreeNode replacementParentNode = nodeToRemove;
                    while (replacementNode.left != null)
                    {
                        replacementParentNode = replacementNode;
                        replacementNode = replacementNode.left;
                    }
                    replacementParentNode.left = null;
                    replacementNode.left = nodeToRemove.left;
                    replacementNode.right = nodeToRemove.right;
                }
            }
            else if (nodeToRemove.left != null)
            {//We only have a Left node
                replacementNode = nodeToRemove.left;
            }

            if (parentNode == null)
            {
                root = replacementNode;
            }
            else if (parentNode.left == nodeToRemove)
            { //We are a Left child
                parentNode.left = replacementNode;
            }
            else
            { //We are a Right child
                parentNode.right = replacementNode;
            }
        }


        public List<int> BreadthFirstSearch()
        {
            var current = root;
            var list = new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                current = queue.Dequeue();
                list.Add(current.val);
                if(current.left != null)
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

        public List<int> BreadthFirstSearchR(Queue<TreeNode> queues,List<int> list)
        {
            if (queues.Count == 0) return list;
            var current = queues.Dequeue();
            list.Add(current.val);
            if(current.left != null)
            {
                queues.Enqueue(current.left);
            }
            if (current.right != null)
            {
                queues.Enqueue(current.right);
            }

            return BreadthFirstSearchR(queues, list);
        }


        int COUNT = 5;
        public void printTree(TreeNode node)
        {
            print2DUtil(root, 0);
        }

        private void print2DUtil(TreeNode root, int space)
        {
            // Base case  
            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.val + "\n");

            // Process left child  
            print2DUtil(root.left, space);
        }



        //static void Main(string[] args)
        //{
        //    BinarySearchTree tree = new BinarySearchTree();
        //    tree.Insert(9);
        //    tree.Insert(4);
        //    tree.Insert(6);
        //    tree.Insert(20);
        //    tree.Insert(170);
        //    tree.Insert(15);
        //    tree.Insert(1);

        //    var aaa = tree.BreadthFirstSearch();
        //    var q = new Queue<BSTNode>();
        //    var list = new List<int>();
        //    q.Enqueue(tree.root);
        //    var bbb = tree.BreadthFirstSearchR(q, list);
        //    Console.WriteLine("Ok");
        //}
    }
}
