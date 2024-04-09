using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiameterOfBinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), new TreeNode(7)));
            //Console.WriteLine(DiameterOfBinaryTree(root));
            Console.WriteLine(root.left.left.val);
            
            //int depth = CalculateDepth(root);

            //Console.WriteLine($"Ağacın derinliği: {depth}");
            Console.ReadLine();
        }
        public static int DiameterOfBinaryTree(TreeNode node, int x = 0)
        {
            if (node == null) return 0;
            int left = DiameterOfBinaryTree(node.left);
            return x;
        }
        static int x;
        static int CalculateDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            int leftDepth = CalculateDepth(node.left);
            int rightDepth = CalculateDepth(node.right);
            x = leftDepth + rightDepth > x ? leftDepth + rightDepth : x;
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
        { 
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
