using ConsoleApp1.TreePractice.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.SearchingPractices
{
    class Solution
    {

        //public bool IsBSTQQ(TreeNode root)
        //{
        //    long min = long.MinValue;
        //    long max = long.MaxValue;
        //    return DDD(root, min, max);
        //}
        
        //// root.left
        //public bool DDD(TreeNode root,long min,long max)
        //{
        //    if (root == null) return true;
        //    if(root.val < max && root.val > min )
        //    {
        //        //再往下找
        //        var IsLeftCurrect = DDD(root.left, min, root.val);
        //        var IsRightCurrent = DDD(root.right, root.val, max);
        //        return IsLeftCurrect && IsRightCurrent;
        //    }
        //    //他已經 不是 BST
        //    return false;
        //}


        public static bool DFS(TreeNode root,long min=long.MinValue,long max = long.MaxValue)
        {
            if (root == null) return true;
            //root.left的值 如果小於 root && root.right的值 大於 root
            //BST 
            // 1. node.left > node
            // 2. node.right < node
            if (min<root.val && max > root.val)
            {
                //再往下找
                ////min 跟 max 初始值是很大 / 很小
                ///現在 往左找的話 max 會是node的值 所以node.left 恆小於 node
                var leftResult = DFS(root.left,min,root.val);
                ///往右找的話 min 會是node node.right 恆大於 node
                var rightResult = DFS(root.right,root.val, max);
                
                return leftResult && rightResult;
            }
            return false;
        }
        public bool IsValidBST(TreeNode root)
        {
            var min = long.MinValue;
            var max = long.MaxValue;
            return DFS(root, min, max);
        }

            public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            //遞迴之後 兩邊都無子結點
            if (p == null && q == null) return true;
            //這邊 其中一個有值
            if (p == null || q == null) return false;
            if(p.val == q.val)
            {
                //遞迴尋找左右結點
                return IsSameTree(p.left, q.left) && IsSameTree(p.right , q.right);
            }
            return false;
        }


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
        //    tree.Insert(877);
        //    var isOK = DFS(tree.root);
        //    Console.WriteLine(isOK);
        //    //BST 
        //    // 1. node.left > node
        //    // 2. node.right < node
        //    // 3. 

        //    //BinarySearchTree q = new BinarySearchTree();
        //    //q.Insert(1);
        //    //q.Insert(2);
        //    //q.Insert(1);

        //    //var a =IsSameTree(p.root, q.root);
        //    //Console.WriteLine(a);
        //}
    }
}

