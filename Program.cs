using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] pArguments)
        {
            // 1. Create the binary tree
            // 2. Print the InOrder tree traversal
            // 3. Print the PreOrder tree traversal
            // 4. Print the PostOrder tree traversal

            BinaryTree binaryTree = new BinaryTree();

            // Root of tree
            binaryTree.Root = new BinaryTree.Node(8);

            // Left side of tree
            binaryTree.Root.Left                    = new BinaryTree.Node(5);
            binaryTree.Root.Left.Left               = new BinaryTree.Node(9);
            binaryTree.Root.Left.Right              = new BinaryTree.Node(7);
            binaryTree.Root.Left.Right.Left         = new BinaryTree.Node(1);
            binaryTree.Root.Left.Right.Right        = new BinaryTree.Node(12);
            binaryTree.Root.Left.Right.Right.Left   = new BinaryTree.Node(2);

            // Right side of tree
            binaryTree.Root.Right               = new BinaryTree.Node(4);
            binaryTree.Root.Right.Right         = new BinaryTree.Node(11);
            binaryTree.Root.Right.Right.Left    = new BinaryTree.Node(3);

            Console.Write("Print InOrder\t- ");
            Program.PrintInOrder(binaryTree.Root);
            Console.WriteLine("");
            Console.Write("Print PreOrder\t- ");
            Program.PrintPreOrder(binaryTree.Root);
            Console.WriteLine("");
            Console.Write("Print PostOrder\t- ");
            Program.PrintPostOrder(binaryTree.Root);
            Console.WriteLine("");
        }

        public static void PrintInOrder(BinaryTree.Node root)
        {
            // In an InOrder search, the left of the tree is searched first, then the root, then the right.
            // 1.Traverse the left subtree
            // 2.Visit the root.
            // 3.Traverse the right subtree

            if (root != null)
            {
                Program.PrintInOrder(root.Left);
                Console.Write(root.Data + " ");
                Program.PrintInOrder(root.Right);
            }
        }

        public static void PrintPreOrder(BinaryTree.Node root)
        {
            // In a PreOrder search, the root of the tree is searched first, then the left, then the right.
            // 1.Visit the root.
            // 2.Traverse the left subtree
            // 3.Traverse the right subtree

            if (root != null)
            {
                Console.Write(root.Data + " ");
                Program.PrintPreOrder(root.Left);
                Program.PrintPreOrder(root.Right);
            }
        }

        public static void PrintPostOrder(BinaryTree.Node root)
        {
            // In a PostOrder search, the left is searched first, then the right, then the root.
            // 1.Traverse the left subtree
            // 2.Traverse the right subtree
            // 3.Visit the root.

            if (root != null)
            {
                Program.PrintPostOrder(root.Left);
                Program.PrintPostOrder(root.Right);
                Console.Write(root.Data + " ");
            }
        }
    }

    // BinaryTree data structure
    public class BinaryTree
    {
        private Node m_root;

        public BinaryTree()
        {
        }

        public Node Root
        {
            get { return this.m_root; }
            set { this.m_root = value; }
        }

        public class Node
        {
            private Node m_right;
            private Node m_left;
            private int m_data;

            public Node(int data)
            {
                this.m_data     = data;
                this.m_right    = null;
                this.m_left     = null;
            }

            public Node Right
            {
                get { return this.m_right; }
                set { this.m_right = value; }
            }

            public Node Left
            {
                get { return this.m_left; }
                set { this.m_left = value; }
            }

            public int Data
            {
                get { return this.m_data; }
                set { this.m_data = value; }
            }
        }
    }
}
