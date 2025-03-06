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

    // Postorder Traversal using Two Stacks
    public void PostOrderIterative()
    {
        if (Root == null)
            return;

        Stack<Node> stack1 = new Stack<Node>();
        Stack<Node> stack2 = new Stack<Node>();

        stack1.Push(Root);

        while (stack1.Count > 0)
        {
            Node current = stack1.Pop();
            stack2.Push(current);

            if (current.Left != null)
                stack1.Push(current.Left);
            if (current.Right != null)
                stack1.Push(current.Right);
        }

        // Print nodes in reverse order
        while (stack2.Count > 0)
        {
            Console.Write(stack2.Pop().Value + " ");
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

        Console.WriteLine("Postorder Traversal (Iterative using Two Stacks):");
        tree.PostOrderIterative();
    }
}
