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

class BST
{
    public Node Root;

    // Insert a value into the BST
    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    private Node InsertRecursive(Node root, int value)
    {
        if (root == null)
            return new Node(value);

        if (value < root.Value)
            root.Left = InsertRecursive(root.Left, value);
        else if (value > root.Value)
            root.Right = InsertRecursive(root.Right, value);

        return root;
    }

    // Search for a value in the BST
    public bool Search(int value)
    {
        return SearchRecursive(Root, value);
    }

    private bool SearchRecursive(Node root, int value)
    {
        if (root == null) return false;
        if (root.Value == value) return true;

        return value < root.Value
            ? SearchRecursive(root.Left, value)
            : SearchRecursive(root.Right, value);
    }

    // Inorder Traversal (Left, Root, Right)
    public void InOrderTraversal()
    {
        InOrderRecursive(Root);
        Console.WriteLine();
    }

    private void InOrderRecursive(Node root)
    {
        if (root != null)
        {
            InOrderRecursive(root.Left);
            Console.Write(root.Value + " ");
            InOrderRecursive(root.Right);
        }
    }
}

class Program
{
    static void Main()
    {
        BST tree = new BST();
        
        // Insert nodes
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("Inorder Traversal:");
        tree.InOrderTraversal();

        // Search for values
        Console.WriteLine("Search 40: " + tree.Search(40)); // True
        Console.WriteLine("Search 100: " + tree.Search(100)); // False
    }
}
