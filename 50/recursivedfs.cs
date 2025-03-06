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

    // Function to count leaf nodes
    public int CountLeafNodes()
    {
        return CountLeaves(Root);
    }

    private int CountLeaves(Node node)
    {
        if (node == null)
            return 0;

        // If node is a leaf, return 1
        if (node.Left == null && node.Right == null)
            return 1;

        // Recur for left and right subtrees
        return CountLeaves(node.Left) + CountLeaves(node.Right);
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Constructing the binary tree:
        tree.Root = new Node(5);
        tree.Root.Left = new Node(3);
        tree.Root.Right = new Node(8);
        tree.Root.Left.Left = new Node(1);
        tree.Root.Left.Right = new Node(4);
        tree.Root.Right.Left = new Node(7);
        tree.Root.Right.Right = new Node(10);

        Console.WriteLine("Number of Leaf Nodes: " + tree.CountLeafNodes());
    }
}
