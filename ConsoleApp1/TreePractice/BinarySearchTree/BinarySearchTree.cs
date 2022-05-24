using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TreePractice.BinarySearchTree
{
    class BSTNode
    {
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
        public int Value { get; set; }

        public BSTNode(int value)
        {
            Left = null;
            Right = null;
            Value = value;
        }
    }

    class BinarySearchTree
    {
        private BSTNode root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            var newNode = new BSTNode(value);
            if (root == null)
            {
                root = newNode;
                return;
            }

            var currentNode = root;
            while (currentNode != null)
            {
                if (currentNode.Value > value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        return;
                    }
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        return;
                    }
                    currentNode = currentNode.Right;
                }
            }
        }


        public BSTNode Lookup(int value)
        {
            if (root == null)
            {
                return null;
            }

            var currentNode = root;
            while (currentNode != null)
            {

                if (currentNode.Value > value)
                {
                    currentNode = currentNode.Left;
                }
                else if(currentNode.Value < value)
                {
                    currentNode = currentNode.Right;
                }
                else if (currentNode.Value == value)
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
            BSTNode parentNode = null;
            while (nodeToRemove.Value != value)
            { //Searching for the node to remove and it's parent
                parentNode = nodeToRemove;
                if (value < nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Left;
                }
                else if (value > nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Right;
                }
            }

            BSTNode replacementNode = null;
            if (nodeToRemove.Right != null)
            { //We have a Right node
                replacementNode = nodeToRemove.Right;
                if (replacementNode.Left == null)
                { //We don't have a Left node
                    replacementNode.Left = nodeToRemove.Left;
                }
                else
                { //We have a have a Left node, lets find the leftmost
                    BSTNode replacementParentNode = nodeToRemove;
                    while (replacementNode.Left != null)
                    {
                        replacementParentNode = replacementNode;
                        replacementNode = replacementNode.Left;
                    }
                    replacementParentNode.Left = null;
                    replacementNode.Left = nodeToRemove.Left;
                    replacementNode.Right = nodeToRemove.Right;
                }
            }
            else if (nodeToRemove.Left != null)
            {//We only have a Left node
                replacementNode = nodeToRemove.Left;
            }

            if (parentNode == null)
            {
                root = replacementNode;
            }
            else if (parentNode.Left == nodeToRemove)
            { //We are a Left child
                parentNode.Left = replacementNode;
            }
            else
            { //We are a Right child
                parentNode.Right = replacementNode;
            }
        }


        //public void Remove(int value)
        //{
        //    if (root == null)
        //    {
        //        return;
        //    }
        //    var nodeToRemove = root;
        //    BSTNode parentNode = null;
        //    while(nodeToRemove.Value != value)
        //    {
        //        //search value
        //        parentNode = nodeToRemove;
        //        if (value < nodeToRemove.Value)
        //        {
        //            nodeToRemove = nodeToRemove.Left;
        //        }
        //        else if (value > nodeToRemove.Value)
        //        {
        //            nodeToRemove = nodeToRemove.Right;
        //        }
        //    }

        //    BSTNode replacementNode = null;
        //    if(nodeToRemove.Right != null)
        //    {
        //        //Right side
        //        //have a Right node
        //        replacementNode = nodeToRemove.Right;
        //        if(replacementNode.Left == null)
        //        {
        //            //don't have a Left node
        //            replacementNode.Left = nodeToRemove.Left;
        //        }
        //        else
        //        {
        //            //have a have a Left node, lets find the leftmost
        //            BSTNode replacementParentNode = nodeToRemove;
        //            while (replacementNode.Left != null)
        //            {
        //                replacementParentNode = replacementNode;
        //                replacementNode = replacementNode.Left;
        //            }
        //            replacementParentNode.Left = null;
        //            replacementNode.Left = nodeToRemove.Left;
        //            replacementNode.Right = nodeToRemove.Right;
        //        }
        //    }
        //    else if(nodeToRemove.Left != null)
        //    {
        //        //We only have a Left node
        //        replacementNode = nodeToRemove.Left;
        //    }

        //    if(parentNode != null)
        //    {
        //        root = replacementNode;
        //    }
        //    else if(parentNode.Left == nodeToRemove)
        //    {
        //        //Left child
        //        parentNode.Left = replacementNode;
        //    }
        //    else
        //    {
        //        //Right child
        //        parentNode.Right = replacementNode;
        //    }
        //}


        int COUNT = 5;
        public void printTree(BSTNode node)
        {
            print2DUtil(root, 0);
        }

        private void print2DUtil(BSTNode root, int space)
        {
            // Base case  
            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.Right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.Value + "\n");

            // Process left child  
            print2DUtil(root.Left, space);
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

        //    var shouldBeFalse = tree.Lookup(10);
        //    var shouldBeTrue = tree.Lookup(170);

        //    tree.Remove(6);
        //    tree.printTree(tree.root);
        //    Console.WriteLine("Ok");
        //}
    }
}
