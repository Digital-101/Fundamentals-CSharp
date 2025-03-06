using System;
using System.Collections.Generic;

class Node
{
    public int Value;
    public Node Left, Right;

    public Node(int value)
    {
        Value = value;
        Left = Right = null;
    }
}

class BinaryTree
{
    public Node Root;

    // Inorder Traversal using Stack (Iterative)
    public void InOrderIterative()
    {
        if (Root == null)
            return;

        Stack<Node> stack = new Stack<Node>();
        Node current = Root;

        while (current != null || stack.Count > 0)
        {
            // Push all left nodes to stack
            while (current != null)
            {
                stack.Push(current);
                current = current.Left;
            }

            // Pop the top node and visit it
            current = stack.Pop();
            Console.Write(current.Value + " ");

            // Move to the right subtree
            current = current.Right;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Constructing the binary tree:
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);
        tree.Root.Right.Left = new Node(6);
        tree.Root.Right.Right = new Node(7);

        Console.WriteLine("Inorder Traversal (without recursion):");
        tree.InOrderIterative();
    }
}
