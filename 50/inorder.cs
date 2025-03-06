using System;

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

    // Inorder Traversal: Left -> Root -> Right
    public void InOrderTraversal()
    {
        InOrderRecursive(Root);
        Console.WriteLine();
    }

    private void InOrderRecursive(Node root)
    {
        if (root == null) return;

        InOrderRecursive(root.Left);   // Recur on left subtree
        Console.Write(root.Value + " "); // Visit the node
        InOrderRecursive(root.Right);  // Recur on right subtree
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

        Console.WriteLine("Inorder Traversal:");
        tree.InOrderTraversal();
    }
}
