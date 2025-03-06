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

    // Postorder Traversal: Left -> Right -> Root
    public void PostOrderTraversal()
    {
        PostOrderRecursive(Root);
        Console.WriteLine();
    }

    private void PostOrderRecursive(Node root)
    {
        if (root == null) return;

        PostOrderRecursive(root.Left);   // Recur on left subtree
        PostOrderRecursive(root.Right);  // Recur on right subtree
        Console.Write(root.Value + " "); // Visit the node
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

        Console.WriteLine("Postorder Traversal (Recursive):");
        tree.PostOrderTraversal();
    }
}
